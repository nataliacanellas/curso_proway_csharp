using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico
    {
        public void Executa()
        {
            byte byteMin = Byte.MinValue; // 8 bits
            byte byteMax = Byte.MaxValue;
            System.Console.WriteLine("Byte min: "+byteMin);
            System.Console.WriteLine("Byte max: " + byteMax);

            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("Sbyte min: " + sbyteMin);
            System.Console.WriteLine("Sbyte max: "+ sbyteMax);

            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine("Short min: " + shortMin);
            System.Console.WriteLine("Short max: " + shortMax);

            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("Short min: " + ushortMin);
            System.Console.WriteLine("Short max: " + ushortMax);

            // similar ao short:
            Int16 int16Min = Int16.MinValue;
            Int16 int16Max = Int16.MaxValue;
            System.Console.WriteLine("int16 min: " + int16Min);
            System.Console.WriteLine("int16 max: " + int16Max);

            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine("int min: " + intMin);
            System.Console.WriteLine("int max: " + intMax);

            Int32 int32Min = int.MinValue;
            Int32 int32Max = int.MaxValue;
            System.Console.WriteLine("int32 min: " + int32Min);
            System.Console.WriteLine("int32 max: " + int32Max);

            Int64 int64Min = int.MinValue;
            Int64 int64Max = int.MaxValue;
            System.Console.WriteLine("int64 min: " + int64Min);
            System.Console.WriteLine("int64 max: " + int64Max);

            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            System.Console.WriteLine("Long min: " + longMin);
            System.Console.WriteLine("Long max: " + longMax);

        }
    }
}
