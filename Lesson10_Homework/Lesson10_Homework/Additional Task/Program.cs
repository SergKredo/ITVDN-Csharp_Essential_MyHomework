using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    /*Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места
заполнения типом – Т).*/
    class MyClass<T> where T: new()   // Использование стериотипа Generics (универсальные шаблоны в других языках программирования)
    {
        public static T FactoryMethod()  // Метод, который будет создавать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т)
        {
            return new T();
        }

    }
    class DefinitionType
    { 
       public void DefinedType()  // Метод, который формирует список объектов из всех созданных нами экземпляров типов, указанных в качестве параметра типа
       { 
            object @object = "";
            object[] massive = new object[14];
            massive[0] = MyClass<sbyte>.FactoryMethod().GetType().FullName;
            massive[1] = MyClass<byte>.FactoryMethod().GetType().FullName;
            massive[2] = MyClass<ushort>.FactoryMethod().GetType().FullName;
            massive[3] = MyClass<short>.FactoryMethod().GetType().FullName;
            massive[4] = MyClass<uint>.FactoryMethod().GetType().FullName;
            massive[5] = MyClass<int>.FactoryMethod().GetType().FullName;
            massive[6] = MyClass<ulong>.FactoryMethod().GetType().FullName;
            massive[7] = MyClass<long>.FactoryMethod().GetType().FullName;
            massive[8] = MyClass<float>.FactoryMethod().GetType().FullName;
            massive[9] = MyClass<double>.FactoryMethod().GetType().FullName;
            massive[10] = MyClass<decimal>.FactoryMethod().GetType().FullName;
            massive[11] = @object.GetType().FullName;
            massive[12] = MyClass<bool>.FactoryMethod().GetType().FullName;
            massive[13] = MyClass<char>.FactoryMethod().GetType().FullName;


            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine("{0} - type(alias): " + CalculateTypeAlias(i) + ",\n  - .Net type: " 
                + massive[i] + ",\n  - range: " + CalculateRangeType(i) + ",\n  - size: "+ CalculateSizeType(i) 
                + ",\n  - ID instance: " + massive[i].GetHashCode()+ "\n", i + 1);
                Console.WriteLine(new string('-', 80));

                string CalculateRangeType(int k)  // Метод, который определяет диапазон значений (минимальное и максимальное) для различных типов
            { 
                switch (massive[k].ToString())
                { 
                    case "System.SByte":
                            return SByte.MinValue.ToString()+" to "+ SByte.MaxValue.ToString();
                    case "System.Byte":
                            return Byte.MinValue.ToString() + " to " + Byte.MaxValue.ToString();
                    case "System.UInt16":
                            return UInt16.MinValue.ToString() + " to " + UInt16.MaxValue.ToString();
                    case "System.Int16":
                            return Int16.MinValue.ToString() + " to " + Int16.MaxValue.ToString();
                    case "System.UInt32":
                            return UInt32.MinValue.ToString() + " to " + UInt32.MaxValue.ToString();
                    case "System.Int32":
                            return Int32.MinValue.ToString() + " to " + Int32.MaxValue.ToString();
                    case "System.UInt64":
                            return UInt64.MinValue.ToString() + " to " + UInt64.MaxValue.ToString();
                    case "System.Int64":
                            return Int64.MinValue.ToString() + " to " + Int64.MaxValue.ToString();
                    case "System.Single":
                            return Single.MinValue.ToString() + " to " + Single.MaxValue.ToString();
                    case "System.Double":
                            return Double.MinValue.ToString() + " to " + Double.MaxValue.ToString();
                    case "System.Decimal":
                            return Decimal.MinValue.ToString() + " to " + Decimal.MaxValue.ToString();
                    case "System.String":
                            return "char[]";
                    case "System.Boolean":
                            return Boolean.TrueString + " to " + Boolean.FalseString;
                    case "System.Char":
                            char[] @char = {Char.MinValue,' ','t', 'o', ' ', Char.MaxValue};
                            string @string = new string(@char);
                            return @string;
                    default:
                            return k.ToString();
                }
                
            }
            string CalculateTypeAlias(int s)  // Метод, который определяет название типа (alias) элемента массива
            {
                    switch (massive[s].ToString())
                    {
                        case "System.SByte":
                            return "sbyte";
                        case "System.Byte":
                            return "byte";
                        case "System.UInt16":
                            return "ushort";
                        case "System.Int16":
                            return "short";
                        case "System.UInt32":
                            return "uint";
                        case "System.Int32":
                            return "int";
                        case "System.UInt64":
                            return "ulong";
                        case "System.Int64":
                            return "long";
                        case "System.Single":
                            return "float";
                        case "System.Double":
                            return "double";
                        case "System.Decimal":
                            return "decimal";
                        case "System.String":
                            return "string";
                        case "System.Boolean":
                            return "bool";
                        case "System.Char":
                            return "char";
                        default:
                            return s.ToString();
                    }

            }
            string CalculateSizeType(int z)  // Метод, который определяет размер объявленной переменной в битах
            {
                    switch (massive[z].ToString())
                    {
                        case "System.SByte":
                            return (sizeof(SByte)*8).ToString() + "-bit";
                        case "System.Byte":
                            return (sizeof(Byte)*8).ToString() + "-bit";
                        case "System.UInt16":
                            return (sizeof(UInt16)*8).ToString() + "-bit";
                        case "System.Int16":
                            return (sizeof(Int16)*8).ToString() + "-bit";
                        case "System.UInt32":
                            return (sizeof(UInt32)*8).ToString() + "-bit";
                        case "System.Int32":
                            return (sizeof(Int32)*8).ToString() + "-bit";
                        case "System.UInt64":
                            return (sizeof(UInt64)*8).ToString() + "-bit";
                        case "System.Int64":
                            return (sizeof(Int64)*8).ToString() + "-bit";
                        case "System.Single":
                            return (sizeof(Single)*8).ToString() + "-bit";
                        case "System.Double":
                            return (sizeof(Double)*8).ToString() + "-bit";
                        case "System.Decimal":
                            return (sizeof(Decimal)*8).ToString() + "-bit";
                        case "System.String":
                            return "?" + "-bit";
                        case "System.Boolean":
                            return (sizeof(Boolean)*8).ToString() + "-bit";
                        case "System.Char":
                            return (sizeof(Char)*8).ToString() + "-bit";
                        default:
                            return z.ToString();
                    }
            }

            }
        
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic information on basic types in C # using a stereotype <Generics>:".ToUpper());
            Console.WriteLine(new string('-', 80));
            DefinitionType definitionType = new DefinitionType();
            definitionType.DefinedType();
            
            Console.ReadKey();
           
        }
    }
}
