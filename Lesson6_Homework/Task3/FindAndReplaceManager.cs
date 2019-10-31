using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    static class FindAndReplaceManager
    {
        public static string sampletext = " Далеко впереди Еле были видны ветряные буркин мельницы еле села еле, справа тянулся и потом исчезал далеко за селом ряд холмов, и оба они знали, что это берег реки, там луга, зеленые ивы, усадьбы(большие дома), и если стать на один из холмов, то оттуда видно такое же громадное поле, телеграф и поезд, который издали похож на ползущую гусеницу, а в ясную погоду оттуда бывает виден даже город. Теперь, в еле тихую погоду, когда вся природа казалась кроткой (послушной, спокойной) и задумчивой, Иван Петрович и Буркин Иван были проникнуты любовью к этому полю и оба думали о том, как велика, как прекрасна эта страна. — В прошлый раз, когда вы были в сарае у старосты Прокофия, — сказал Буркин, — вы собирались рассказать какую-то историю. — Да, я хотел тогда рассказать про своего брата. Иван Петрович протяжно вздохнул и закурил трубочку, чтобы начать рассказывать, но как раз в это время пошел дождь. И минут через пять лил уже сильный дождь, обложной (долгий), и трудно было предвидеть, когда он кончится. Иван Петрович и Буркин остановились в раздумье; собаки, уже мокрые, стояли, поджав хвосты, и смотрели на них с умилением(с нежностью). — Нам нужно укрыться(спрятаться) куда-нибудь, — сказал Буркин. — Пойдемте к Алехину. Тут близко. — Пойдемте. Они свернули в сторону и шли всё по скошенному полю, то прямо, то забирая направо, пока не вышли на дорогу. Скоро показались тополи, сад, потом красные крыши амбаров; заблестела река, и открылся вид на широкий плес с мельницей и белою купальней. Это было Софьино, где жил Алехин. ";
        public static string replaceText = null;

        public class Note
        {
        public static void FindNext(string str)
        {
                #region Объявление локальных переменных и массивов

                int p = 0, n = 0, w = 0;
            char replaceUpperChar = str[0];
            char replaceDownChar = str[0];
            replaceUpperChar = char.ToUpper(replaceUpperChar);
            replaceDownChar = char.ToLower(replaceDownChar);
                if (replaceText != null)   // Условная конструкция характеризующая повторную операцию с текстом в котором находятся ранее сделанные заметки
                {
                    sampletext = replaceText;
                    replaceText = null;
                }
            int sum = 0;
            char[] notechar = new char[sampletext.Length];
            char[] notecharword = new char[sampletext.Length];
            char[][] newTextWithNote = new char[3][];
                #endregion


                #region 1) Алгоритм для вывод текста со встречающимися словами и внесенными заметками

                char[][][] newTextWithNoteBigMatrix = new char[20][][];   // Объявление большого зубчатого массива массивов, который состоит из нескольких малых зубчатых массивов массивов, в каждом из которых определены 3-и одномерных подмассива типа char.
                {
                    
                    for (int z = 0; z < newTextWithNoteBigMatrix.Length; z++)
                    {
                            for (; p < sampletext.Length; p++)
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
                                            notecharword[w] = sampletext[p];
                                            ++p;
                                            ++w;
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                    }
                                ++sum;
                                notecharword[w] = sampletext[p];
                                Console.Write(sampletext[p]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                string note = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Gray;

                                char[] notecharbehind = new char[note.Length + 20];
                                if (string.IsNullOrEmpty(note))
                                {
                                    notecharbehind = null;
                                }
                                else 
                                {
                                for (int i = 0; i < note.Length + 20; i++)
                                {
                                    if (i < 10)
                                    {
                                        if (i < 5)
                                        {
                                            notecharbehind[i] = '$';
                                            continue;
                                        }
                                        notecharbehind[i] = '_';
                                        continue;
                                    }
                                    if (i >= note.Length + 10)
                                    {
                                        if (i >= note.Length + 15)
                                        {
                                            notecharbehind[i] = '$';
                                            continue;
                                        }
                                        notecharbehind[i] = '_';
                                        continue;
                                    }

                                    notecharbehind[i] = note[i - 10];
                                    notecharbehind[i] = char.ToUpper(notecharbehind[i]);
                                }
                                }

                                char[] notecharChange = new char[n];
                                for (int i = 0; i < n; i++)
                                {
                                    notecharChange[i] = notechar[i];
                                }

                                char[] notecharWordChange = new char[str.Length + 1];
                                for (int i = 0; i < str.Length + 1; i++)
                                {
                                    notecharWordChange[i] = notecharword[i];
                                }

                                newTextWithNote = new char[3][];
                                newTextWithNote[0] = notecharChange;
                                newTextWithNote[1] = notecharWordChange;
                                newTextWithNote[2] = notecharbehind;
                                n = 0;
                                w = 0;
                                break;
                            }
                            #endregion

                            #region 1.2. Алгоритм для слова из нескольких литералов

                            #region Последовательный вывод в консоли литералов заданного слова

                            if (str.Length >= 2 && (replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p] || str[0] == sampletext[p]) && str[1] == sampletext[p + 1] && str[str.Length - 1] == sampletext[p + (str.Length - 1)] && sampletext[p - 1] == ' ' && (sampletext[p + (str.Length)] == ' ' || sampletext[p + (str.Length)] == '.' || sampletext[p + (str.Length)] == ','))
                                {
                                    for (int i = 0; i < str.Length; i++)
                                    {
                                        if (str[i] == sampletext[p] || replaceUpperChar == sampletext[p] || replaceDownChar == sampletext[p])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(sampletext[p]);
                                            notecharword[w] = sampletext[p];
                                            ++p;
                                            ++w;
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                    }
                                    ++sum;
                                    notecharword[w] = sampletext[p];
                                    Console.Write(sampletext[p]);
                                    Console.ForegroundColor = ConsoleColor.Green;

                                #region Запись с консоли введенной заметки

                                string note = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                #region Объявление одномерного массива типа char, в котором хранятся все значения символов нашей заметки

                                char[] notecharbehind = new char[note.Length+20];
                                if (string.IsNullOrEmpty(note))
                                {
                                    notecharbehind = null;
                                }
                                else
                                {
                                    for (int i = 0; i < note.Length + 20; i++)
                                    {
                                        if (i < 10)
                                        {
                                            if (i < 5)
                                            {
                                                notecharbehind[i] = '$';
                                                continue;
                                            }
                                            notecharbehind[i] = '_';
                                            continue;
                                        }
                                        if (i >= note.Length + 10)
                                        {
                                            if (i >= note.Length + 15)
                                            {
                                                notecharbehind[i] = '$';
                                                continue;
                                            }
                                            notecharbehind[i] = '_';
                                            continue;
                                        }

                                        notecharbehind[i] = note[i - 10];
                                        notecharbehind[i] = char.ToUpper(notecharbehind[i]);
                                    }
                                }
                                #endregion

                                #endregion


                                #region Объявление одномерного массива типа char, в котором хранятся все значения символов слов до 1-го вхождения и после заданного слова

                                char[] notecharChange = new char[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        notecharChange[i] = notechar[i];
                                    }
                                #endregion

                                #region Объявление одномерного массива типа char, в котором хранятся все значения символов слов заданного слова

                                char[] notecharWordChange = new char[str.Length + 1];
                                    for (int i = 0; i < str.Length + 1; i++)
                                    {
                                        notecharWordChange[i] = notecharword[i];
                                    }
                                #endregion

                                #region Объявление зубчатого массива массивов, в который входят три подмассива с хранящимися в них значениями символов текста

                                newTextWithNote = new char[3][];
                                    newTextWithNote[0] = notecharChange;
                                    newTextWithNote[1] = notecharWordChange;
                                    newTextWithNote[2] = notecharbehind;
                                    n = 0;
                                    w = 0;
                                    break;
                                #endregion

                                }
                            #endregion

                            #endregion

                            #region Последовательны вывод в консоли литералов - до первого вхождения в заданное слово

                                if (sum == 0)
                                {
                                    notechar[n] = sampletext[p];
                                    Console.Write(sampletext[p]);
                                    ++n;
                                }
                            #endregion

                            #region Последовательный вывод в консоли литералов - после 1-го и n раз вхождений заданного слова в тексте 

                            if (sum > 0)
                                {
                                    notechar[n] = sampletext[p];
                                    Console.Write(sampletext[p]);
                                    ++n;

                                if (p == sampletext.Length - 1)
                                {
                                    char[] notecharChange = new char[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        notecharChange[i] = notechar[i];
                                    }
                                    newTextWithNote = new char[3][];
                                    newTextWithNote[0] = notecharChange;
                                    newTextWithNote[1] = null;
                                    newTextWithNote[2] = null;
                                    n = 0;
                                    w = 0;
                                    break;
                                }
                                }
                            #endregion

                            }

                        newTextWithNoteBigMatrix[z] = newTextWithNote;   // Присвоение большому зубчатому массиву массивов значений от малого зубчатого массива массивов, в котором хранятся все значения символов текста
                    }

                    #region Прочие действия в консоли

                    Console.WriteLine();
                    Console.WriteLine(new string('-', 120));
                    Console.Write(new string('-', 120));
                    string headline = "Текст с Вашими заметками:";
                    headline = headline.PadLeft(70);
                    Console.WriteLine(headline.ToUpper());
                    Console.Write(new string('-', 120) + "\n");
                    #endregion

                    #region Инициализация элементов большого зубчатого массива массивов

                    for (int s = 0; s < newTextWithNoteBigMatrix.Length; s++)
                    {
                        int l = s;
                        if (s == l)
                        {
                        for (int f = 0; f < newTextWithNote.Length; f++)
                        {
                                if (newTextWithNoteBigMatrix[s][f] == null)
                                {
                                    continue;
                                }
                                for (int g = 0; g < newTextWithNoteBigMatrix[s][f].Length; g++)
                                {
                                    if (f == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    }
                                    if (f == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }
                                    Console.Write(newTextWithNoteBigMatrix[s][f][g]);
                                    replaceText += newTextWithNoteBigMatrix[s][f][g];
                                }
                                Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        }
                    }
                    #endregion
                    
                }

            #endregion
        }
        
        }
    }
}
