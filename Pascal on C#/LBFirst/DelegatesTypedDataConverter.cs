using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LBFirst
{
    public class DelegatesTypedDataConverter<T> : ITypedDataConverter<T>
    {
        public int RecordSize { get; private set; }

        public delegate bool TestDelegate<T>(T x);
        TestDelegate<T> testDelegate = (t) => { if (t != null) return true; return false; };

        public delegate void ActionDelegate<T>(T value);
        public delegate byte[] ToByteArrayDelegate<T>(T value);
        public delegate T FromByteArrayDelegate<T>(byte[] data);

        private ToByteArrayDelegate<T> d1;
        private FromByteArrayDelegate<T> d2;

        public DelegatesTypedDataConverter(int RecordSize, ToByteArrayDelegate<T> d1, FromByteArrayDelegate<T> d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        public delegate int CompareDelegate<T>(T t1, T t2);
        CompareDelegate<T> compareDelegate = (t1, t2) => { return t1.ToString().CompareTo(t2.ToString()); };

        public byte[] ToByteArray(T value)
        {
            return d1(value);
        }

        public T FromByteArray(byte[] data)
        {
            return d2(data);
        }
    }
}