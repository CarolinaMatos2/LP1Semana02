using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maximum and minimum values of all types
            sbyte sb1 = sbyte.MaxValue;
            sbyte sb2 = sbyte.MinValue;
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);

            int i1 = int.MaxValue;
            int i2 = int.MinValue;
            Console.WriteLine(i1);
            Console.WriteLine(i2);

            uint ui1 = uint.MaxValue;
            uint ui2 = uint.MinValue;
            Console.WriteLine(ui1);
            Console.WriteLine(ui2);

            ulong u1 = ulong.MaxValue;
            ulong u2 = ulong.MinValue;
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            long l1 = long.MaxValue;
            long l2 = long.MinValue;
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            double d1 = double.MaxValue;
            double d2 = double.MinValue;
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            byte b1 = byte.MaxValue;
            byte b2 = byte.MinValue;
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            short s1 = short.MaxValue;
            short s2 = short.MinValue;
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            ushort us1 = ushort.MaxValue;
            ushort us2 = ushort.MinValue;
            Console.WriteLine(us1);
            Console.WriteLine(us2);

            char c1 = char.MaxValue;
            char c2 = char.MinValue;
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // special values and NaN
            double x1 = double.PositiveInfinity;
            double x2 = double.NegativeInfinity;
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            float f1 = float.PositiveInfinity;
            float f2 = float.NegativeInfinity;
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            float f3 = float.PositiveInfinity;
            Console.WriteLine(f3);

            // Ex 7 OverFlow in uint
            uint ut = uint.MaxValue;
            Console.WriteLine($"Maximum value for uint {ut}");
            
            uint OverFlowResult = ut + 1;
            Console.WriteLine($"Overflow in uint {OverFlowResult}");

            // Overflow in floats
            float fl1 = 2 * float.MaxValue;
            float fl2 = float.MaxValue + 1;
            Console.WriteLine(fl1);
            Console.WriteLine(fl2);
        }
    }
}
