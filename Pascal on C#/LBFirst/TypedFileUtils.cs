using System;
using System.Collections.Generic;
using static LBFirst.DelegatesTypedDataConverter<string>;

namespace LBFirst
{
    public class TypedFileUtils
    {
        public static void Remove<T>(int pos, TypedFile<T> typedfile)
        {
            typedfile.Reset();
            T[] s = Read(typedfile);
            List<T> l = new List<T>();
            for (int i = 0; i < s.Length; i++)
            {
                if (i != pos)
                    l.Add(s[i]);
            }

            typedfile.Rewrite();
            for (int i = 0; i < s.Length; i++)
            {
                typedfile.Append();
                typedfile.Write(l[i]);
            }            
        }

        public static bool Exists<T>(TypedFile<T> typedfile, TestDelegate<T> testDelegate)
        {
            typedfile.Reset();
            while (!typedfile.Eof)
                if (testDelegate(typedfile.Read()))
                    return true;
            return false;
        }

        public static T[] Read<T>(TypedFile<T> typedfile)
        {
            typedfile.Reset();
            T[] record = new T[typedfile.FileSize];
            int i = 0;
            //typedfile.Reset();
            while (!typedfile.Eof)
                record[i++] = typedfile.Read();

            return record;
        }

        public static T ReadFirst<T>(TypedFile<T> typedfile, TestDelegate<T> testDelegate)
        {
            typedfile.Reset();
            T[] array = Read(typedfile);
            for (int i = 0; i < array.Length; i++)
                if (testDelegate(array[1]))
                    return array[1];
            throw new Exception();
        }

        public static T ReadLast<T>(TypedFile<T> typedfile, TestDelegate<T> testDelegate)
        {
            typedfile.Reset();
            T[] array = Read(typedfile);
            for (int i = array.Length - 1; i >= 0; i--)
                if (testDelegate(array[i]))
                    return array[i];
            throw new Exception();
        }

        public static int GetIndex<T>(TypedFile<T> typedfile, TestDelegate<T> testDelegate)
        {
            typedfile.Reset();
            T[] array = Read(typedfile);
            for (int i = 0; i < array.Length; i++)
                if (testDelegate(array[i]))
                    return i;
            throw new NotImplementedException();
        }

        public static int FindLastIndex<T>(TypedFile<T> typedfile, TestDelegate<T> testDelegate)
        {
            typedfile.Reset();
            T[] array = Read(typedfile);
            for (int i = array.Length - 1; i >= 0; i--)
                if (testDelegate(array[i]))
                    return i;
            throw new NotImplementedException();
        }

        public static void ForEach<T>(IList<T> ilist, ActionDelegate<T> actionDelegate)
        {
            foreach (T t in ilist)
                actionDelegate(t);
        }

        public static void ChangeAll<T>(TypedFile<T> typedfile, ActionDelegate<T> actionDelegate)
        {
            typedfile.Reset();
            T[] array = Read(typedfile);
            for (int i = 0; i < array.Length; i++)
                actionDelegate(array[i]);
        }

        public static void Sort<T>(TypedFile<T> typedfile, CompareDelegate<T> compareDelegate)
        {
            typedfile.Reset();
            T[] array = Read(typedfile);
            
            int inner, outer;
            T temp;
            int h = 1;
            while (h <= array.Length / 3)
                h = h * 3 + 1;

            while (h > 0)
            {
                for (outer = h; outer < array.Length; outer++)
                {
                    temp = array[outer];
                    inner = outer;

                    while (inner > h - 1 && compareDelegate(array[inner - h], temp) >= 0)
                    {
                        array[inner] = array[inner - h];
                        inner -= h;
                    }
                    array[inner] = temp;
                }
                h = (h - 1) / 3;
            }

            typedfile.Rewrite();
            foreach (var item in array)
                typedfile.Write(item);
        }

        public static bool CheckForAll<T>(TypedFile<T> typedfile, TestDelegate<T> testDelegate)
        {
            typedfile.Reset();
            while (!typedfile.Eof)
            {
                T t = typedfile.Read();
                if (!testDelegate(t))
                    return false;
            }
            return true;
        }
    }
}
