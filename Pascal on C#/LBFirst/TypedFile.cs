using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LBFirst
{
    public class TypedFile<T>
    {
        public int RecordSize { get; set; }
        public int FileSize
        {
            get
            {
                return (int)new FileInfo(FileName).Length;
            }
        }
        public FileMode FileMode { get; set; }
        public string FileName { get; private set; }
        public int Pos { get; set; }
        public bool Eof
        {
            get
            {
                return Pos >= FileSize;
            }
        }

        private FileStream _FileStream = null;

        public void Assign(string FileName) 
        {
            try { _FileStream.Close(); }
            catch { }
            this.FileName = (System.Diagnostics.Debugger.IsAttached ? "../../" + FileName : FileName);
            _FileStream = new FileStream(FileName, FileMode.OpenOrCreate);
            _FileStream.Close();
        }

        private bool _isAppend { get; set; }

        public void Reset() 
        {
            try { _FileStream.Close(); }
            catch { }
            _FileStream = new FileStream(FileName, FileMode.Open);
            _FileStream.Position = 0;
            Pos = 0;
        }

        public void Rewrite()
        {
            try { _FileStream.Close(); }
            catch { }
            _FileStream = new FileStream(FileName, FileMode.Create);
            Pos = 0;
        }

        public void Append() 
        {
            try { _FileStream.Close(); }
            catch { }
            _FileStream = new FileStream(FileName, FileMode.Append);
            Pos = FileSize;
        }

        public void Seek(long new_pos) 
        {
            _FileStream.Seek(new_pos, SeekOrigin.Begin);
            Pos = (int)new_pos;
        }

        public void Truncate() 
        {
            try { _FileStream.Close(); }
            catch { }
            _FileStream = new FileStream(FileName, FileMode.Open);
            int oldPos = Pos;
            Seek(0);
            string tempFileName = Path.GetTempFileName();
            StreamWriter SW = new StreamWriter(new FileStream(tempFileName, FileMode.Create));
            StreamReader SR = new StreamReader(_FileStream);
            char[] array = new char[oldPos];
            SR.ReadBlock(array, 0, oldPos);
            SW.Write(new String(array));
            Close();
            SW.Close();
            File.Delete(FileName);
            File.Move(tempFileName, FileName);
        }

        public void Write(T value)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            formatter.Serialize(_FileStream, value);
            Pos = value.ToString().Length + 1;
        }

        public T Read()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            return (T)formatter.Deserialize(_FileStream); ;
        }

        public void Close()
        {
            _FileStream.Close();
        }
    }
}