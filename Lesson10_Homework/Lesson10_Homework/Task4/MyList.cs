using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyList<T>  // Использование стериотипа Generics
    {
        int sizeMassive, count;
        int[] iD, ID2;
        object def;
        object[] massiveInstance, massiveInstanceAdd;
        Random random = new Random();  // Создание экземпляра псевдослучайных чисел
        public object[] DefinitionObjects()  // Метод, который формирует список псевдослучайных объектов различных типов
        {
            sizeMassive = random.Next(1, 20);
            massiveInstance = new object[sizeMassive];
            iD = new int[sizeMassive];
            for (int i = 0; i < massiveInstance.Length; i++)
            {
                def = new object();
                massiveInstance[i] = def;
                iD[i] = massiveInstance[i].GetHashCode();
                massiveInstance[i] = instanceMassive();
            }
            return massiveInstance;
        }
        enum List   // Объявление перечисления, в теле которого названия всех основных типов языка C#
        {
            SByte = 1,
            Byte,
            UInt16,
            Int16,
            UInt32,
            Int32,
            UInt64,
            Int64,
            Single,
            Double,
            Decimal,
            String,
            Boolean,
            Char
        }
        private object instanceMassive()   // Метод, который присваивает каждому объявленному элементу в списке определенное значение типа
        {
            int number = random.Next(1, 15);
            switch (number)
            {
                case (int)List.SByte:
                    return (sbyte)-128;
                case (int)List.Byte:
                    return (byte)255;
                case (int)List.UInt16:
                    return (ushort)65535;
                case (int)List.Int16:
                    return (short)-32768;
                case (int)List.UInt32:
                    return 4294967295;
                case (int)List.Int32:
                    return -2147483648;
                case (int)List.UInt64:
                    return 18446744073709551615;
                case (int)List.Int64:
                    return -9223372036854775808;
                case (int)List.Single:
                    return -3.402823E+38f;
                case (int)List.Double:
                    return -1.79769313486231E+308d;
                case (int)List.Decimal:
                    return -79228162514264337593543950335m;
                case (int)List.String:
                    return "ITVDN forever";
                case (int)List.Boolean:
                    return true;
                case (int)List.Char:
                    return 'S';
                default:
                    return null;
            }
        }

        public object[] Add(object[] a)  // Метод, который позволяет добавить в конце первоначального списка дополнительное число других объектов
        {
            int count = 0;
            ID2 = new int[a.Length];
            massiveInstanceAdd = new object[massiveInstance.Length + a.Length];
            Console.WriteLine();
            for (int i = 0; i < massiveInstanceAdd.Length; i++)
            {
                if (i >= massiveInstanceAdd.Length - a.Length && i < massiveInstanceAdd.Length + 1)
                {
                    massiveInstanceAdd[i] = new object();
                    ID2[count] = massiveInstanceAdd[i].GetHashCode();
                    massiveInstanceAdd[i] = a[count++];
                }
                else
                {
                    massiveInstanceAdd[i] = massiveInstance[i];
                }
            }
            return massiveInstanceAdd;
        }
    }
}
