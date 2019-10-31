using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class FindAndReplaceManager
    {
        public static string sampletext = " Далеко впереди Еле были видны ветряные буркин мельницы еле села еле, справа тянулся и потом исчезал далеко за селом ряд холмов, и оба они знали, что это берег реки, там луга, зеленые ивы, усадьбы(большие дома), и если стать на один из холмов, то оттуда видно такое же громадное поле, телеграф и поезд, который издали похож на ползущую гусеницу, а в ясную погоду оттуда бывает виден даже город. Теперь, в еле тихую погоду, когда вся природа казалась кроткой (послушной, спокойной) и задумчивой, Иван Петрович и Буркин Иван были проникнуты любовью к этому полю и оба думали о том, как велика, как прекрасна эта страна. — В прошлый раз, когда вы были в сарае у старосты Прокофия, — сказал Буркин, — вы собирались рассказать какую-то историю. — Да, я хотел тогда рассказать про своего брата. Иван Петрович протяжно вздохнул и закурил трубочку, чтобы начать рассказывать, но как раз в это время пошел дождь. И минут через пять лил уже сильный дождь, обложной (долгий), и трудно было предвидеть, когда он кончится. Иван Петрович и Буркин остановились в раздумье; собаки, уже мокрые, стояли, поджав хвосты, и смотрели на них с умилением(с нежностью). — Нам нужно укрыться(спрятаться) куда-нибудь, — сказал Буркин. — Пойдемте к Алехину. Тут близко. — Пойдемте. Они свернули в сторону и шли всё по скошенному полю, то прямо, то забирая направо, пока не вышли на дорогу. Скоро показались тополи, сад, потом красные крыши амбаров; заблестела река, и открылся вид на широкий плес с мельницей и белою купальней. Это было Софьино, где жил Алехин. ";

        public static void FindNext(string str)
        {
            int p = 0, d = 0;
            char replaceUpperChar = str[0];                 
            char replaceDownChar = str[0];
            replaceUpperChar = char.ToUpper(replaceUpperChar);
            replaceDownChar = char.ToLower(replaceDownChar); 

            
            #region 1) Алгоритм для вывод текста со встречающимися словами

            for (p = 0; p < sampletext.Length; p++)
            {

            #region 1.1. Алгоритм для слова из одного литерала

                if (str.Length == 1 && (replaceDownChar == sampletext[p] || replaceUpperChar == sampletext[p] || str[0] == sampletext[p]) && sampletext[p - 1] == ' ' && (sampletext[p + (str.Length)] == ' ' || sampletext[p + (str.Length)] == '.' || sampletext[p + (str.Length)] == ','))
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == sampletext[p] || replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(sampletext[p]);
                            ++p;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    Console.Write(sampletext[p]);
                    continue;
                }
                #endregion

            #region 1.2. Алгоритм для слова из нескольких литералов
                if (str.Length >= 2 && (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p] || str[0] == sampletext[p]) && str[1] == sampletext[p + 1] && str[str.Length - 1] == sampletext[p + (str.Length - 1)] && sampletext[p - 1] == ' ' && (sampletext[p + (str.Length)] == ' ' || sampletext[p + (str.Length)] == '.' || sampletext[p + (str.Length)] == ','))
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == sampletext[p] || replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(sampletext[p]);
                            ++p;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    Console.Write(sampletext[p]);
                    continue;
                }
                Console.Write(sampletext[p]);
                #endregion

            }

            #region 1.3. Прочие действия

            Console.WriteLine();
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Вывод в тексте заданного слова последовательно в предложениях: \n");
            Console.WriteLine(new string('-', 120));
            Console.ReadKey();
            #endregion

            #endregion


            #region 2) Алгоритм для последовательного вывода предложений из текста, в которых встречается заданное слово

            #region Циклическая конструкция для последовательного перебора всех литералов в тексте

            int sum = 0, sum2 = 0;
            for (p = 0; p < sampletext.Length; p++)
            {
            #region 2.1. Алгоритм для слова из одного литерала
                if (str.Length == 1 && (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p]) && (sampletext[p - 1] == ' ' && sampletext[p + 1] == ' '))
                {
                    if (sum == 0)
                    {
                        for (d = 0; d < sampletext.Length; d++)
                        {
                            for (int i = 0; i < sampletext.Length; i++)
                            {
                                if (sum2 == 0 && (sampletext[p - i] == sampletext[1] || (sampletext[p - i] == '.' && sampletext[p-i+1] == ' ')))
                                {
                                    int sum3 = 0;
                                    int sum4 = 0;

                            #region 2.1.1. Циклическая конструкция для отображения текста в предложении до первого вхождения заданного слова

                                    for (int l = 0; l < sampletext.Length; l++)
                                    {
                                        if ((replaceUpperChar != sampletext[p - i + l] || replaceDownChar != sampletext[p - i + l]) && (sampletext[p - i + l - 1] != ' ' || sampletext[p - i + l + 1] != ' ' || (sampletext[p -i +l] != replaceUpperChar && sampletext[p - i + l] != replaceDownChar)))
                                        {
                                            if (l == 0 && sampletext[p - i + l] == '.' || sum3 <= 2)
                                            {
                                                ++sum3;
                                                continue;
                                            }
                                            if (sum4 == 0 && sampletext[p - i + l-3] == '.')
                                            {
                                                ++sum4;
                                                continue;
                                            }
                                            Console.Write(sampletext[p - i + l - 3]);
                                        }
                                        else
                                        {
                                            if (sampletext[p - i + l] == replaceUpperChar)
                                            {
                                                break;
                                            }
                                                for (int u = 0; u < 3; u++)
                                                {
                                                Console.Write(sampletext[p - i + l - 3]);
                                                ++l;
                                                }

                                            break;
                                        }

                                    }

                                    #endregion

                            #region 2.1.2. Циклическая конструкция для отображения 1-го вхождения заданного слова в предложении

                                    for (int e = 0; e < str.Length; e++)
                                    {
                                        if (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p] || str[e] == sampletext[p])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(sampletext[p]);
                                            ++p;
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                    }
                                    break;

                                    #endregion

                                }
                            }
                            ++sum2;

                            #region 2.1.4. Циклическая конструкция для последующего n раз отображения заданного слова после 1-го вхождения

                            if (sum > 0)
                            {
                                for (int i = 0; i < str.Length; i++)
                                {
                                    if ((replaceUpperChar == sampletext[p+d] || replaceDownChar == sampletext[p+d]) || str[0] == sampletext[p+d])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(sampletext[p+d]);
                                        ++p;
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                }

                            }

                            #endregion


                            #region 2.1.3. Циклическая конструкция для отображения текста в предложении после первого и последующих вхождений заданного слова

                            for ( ; d < sampletext.Length; d++)
                            {
                                
                                if ((replaceUpperChar != sampletext[p + d] || replaceDownChar != sampletext[p + d]) && (sampletext[p + d - 1] != ' ' || sampletext[p + d + 1] != ' ' || (sampletext[p + d] != replaceDownChar && sampletext[p + d] != replaceUpperChar)))
                                {
                                    if (sampletext[p + d] != '.')
                                    {
                                        Console.Write(sampletext[p + d]);
                                    }
                                    else
                                    {
                                        sum = 0;
                                        Console.Write(sampletext[p + d] + "\n\n");
                                        p += d;
                                        d = 0;
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                else
                                {
                                    ++sum;
                                    --d;
                                    break;
                                }


                            }
                            if (d == 0)
                            {
                                sum2 = 0;
                                break;
                            }

                            #endregion

                        }
                    }
                }
                #endregion

            #region 2.2. Алгоритм для слова из нескольких литералов

                if (str.Length >= 2 && (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p] || str[0] == sampletext[p]) && str[1] == sampletext[p + 1] && str[str.Length - 1] == sampletext[p + (str.Length - 1)] && sampletext[p - 1] == ' ' && (sampletext[p + (str.Length)] == ' ' || sampletext[p + (str.Length)] == '.' || sampletext[p + (str.Length)] == ','))
                    {
                        if (sum == 0)
                        {
                            for (d = 0; d < sampletext.Length; d++)
                            {
                                if ((sampletext[p - d] == '.' && (sampletext[p - d + 1] == ' ' || sampletext[p - d + 1] == '-' || sampletext[p - d + 1] != ' ')) || (sampletext[p - d] == sampletext[1] && sampletext[p - d] != ' '))
                                {

                            #region 2.2.1. Циклическая конструкция для отображения текста в предложении до первого вхождения заданного слова

                                for (int l = 0; l < sampletext.Length; l++)
                                    {
                                        if (((replaceUpperChar != sampletext[p - d + l] && (sampletext[p - d + l] != str[0] || str[str.Length - 1] != sampletext[p - d + l + (str.Length - 1)])) || (replaceDownChar != sampletext[p - d + l] && (sampletext[p - d + l] != str[0] || str[str.Length - 1] != sampletext[p - d + l + (str.Length - 1)]))) && (sampletext[p - d + l + 1] != str[1] || str[str.Length - 1] != sampletext[p - d + l + (str.Length - 1)]) || (sampletext[p - d + l - 1] != ' ' || sampletext[p - d + l + (str.Length / 2)] != str[str.Length / 2]))
                                        {
                                            if (l == 0 && sampletext[p - d + l] == '.')
                                            {
                                                continue;
                                            }
                                            Console.Write(sampletext[p - d + l]);
                                        }
                                        else
                                        {

                                            break;
                                        }
                                    }
                                #endregion

                            #region 2.2.2. Циклическая конструкция для отображения 1-го вхождения заданного слова в предложении

                                for (int i = 0; i < str.Length; i++)
                                    {
                                        if (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p] || str[i] == sampletext[p])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(sampletext[p]);
                                            ++p;
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                    }
                                    break;
                                #endregion

                                }
                            }
                        }

                            #region 2.2.4. Циклическая конструкция для последующего n раз отображения заданного слова после 1-го вхождения

                    if (sum > 0)
                        {
                            for (int i = 0; i < str.Length; i++)
                            {
                                if (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p] || str[i] == sampletext[p])
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(sampletext[p]);
                                    ++p;
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }

                        }
                    #endregion

                            #region 2.2.3. Циклическая конструкция для отображения текста в предложении после первого и последующих вхождений заданного слова

                    for (d = 0; d < sampletext.Length; d++)
                        {
                            int i = 0;
                            if ((((replaceUpperChar != sampletext[p + d] && (str[i] != sampletext[p + d] || str[str.Length - 1] != sampletext[p + d + (str.Length - 1)])) || (replaceDownChar != sampletext[p + d]) && (str[i] != sampletext[p + d] || str[str.Length - 1] != sampletext[p + d + (str.Length - 1)])) && (str[i + 1] != sampletext[p + d + 1] || str[str.Length / 2] != sampletext[p + d + 2] || str[str.Length - 1] != sampletext[p + d + (str.Length - 1)])) || (sampletext[p + d - 1] != ' ' || sampletext[p + d + (str.Length / 2)] != str[str.Length / 2]))
                            {
                                if (sampletext[p + d] != '.')
                                {
                                    Console.Write(sampletext[p + d]);
                                }
                                else
                                {
                                    sum = 0;
                                    Console.Write(sampletext[p + d] + "\n\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                ++sum;
                                break;
                            }


                        }
                    #endregion

                    }
                #endregion
            }
            #endregion
            #endregion
        }
    }
}
