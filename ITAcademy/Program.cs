using System;

namespace ITAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            // явное преобразование
            float floatValue = 123.155F;
            int intValue = (int)floatValue;
            ushort ushortValue = (ushort)intValue;
            byte byteValue = (byte)ushortValue;

            // не явное преобразование
            sbyte sbyteValue = 1;
            int intValue2 = sbyteValue;
            double doubleValue = intValue2;

            // упаковка-распаковка
            object charBoxing = 'M';
            char charUnboxing = (char)charBoxing;

            var int32Value = 333;
            object obj32 = int32Value;

            int32Value = 444;
        }
    }
}
