using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBFirst
{
    interface ITypedDataConverter<T>
    {
        int RecordSize { get; }

        byte[] ToByteArray(T value);

        T FromByteArray(byte[] data);
    }
}
