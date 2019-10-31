using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Dictionary
    {
        private string[] keyRus = new string[20];
        private string[] keyEng = new string[20];
        private string[] keyUkr = new string[20];
        private string[] valueRus_Eng = new string[20];
        private string[] valueEng_rus = new string[20];
        private string[] valueRus_Ukr = new string[20];
        private string[] valueUkr_Rus = new string[20];
        private string[] valueEng_Ukr = new string[20];
        private string[] valueUkr_Eng = new string[20];

        public Dictionary()
        {
            keyRus[0] = "книга"; valueRus_Eng[0] = "book"; keyEng[0] = valueRus_Eng[0]; valueEng_rus[0] = keyRus[0];
            keyRus[1] = "ручка"; valueRus_Eng[1] = "pen"; keyEng[1] = valueRus_Eng[1]; valueEng_rus[1] = keyRus[1];
            keyRus[2] = "солнце"; valueRus_Eng[2] = "sun"; keyEng[2] = valueRus_Eng[2]; valueEng_rus[2] = keyRus[2];
            keyRus[3] = "яблоко"; valueRus_Eng[3] = "apple"; keyEng[3] = valueRus_Eng[3]; valueEng_rus[3] = keyRus[3];
            keyRus[4] = "стол"; valueRus_Eng[4] = "table"; keyEng[4] = valueRus_Eng[4]; valueEng_rus[4] = keyRus[4];

            valueRus_Ukr[0] = "книга"; keyUkr[0] = valueRus_Ukr[0]; valueUkr_Rus[0] = keyRus[0];
            valueRus_Ukr[1] = "ручка"; keyUkr[1] = valueRus_Ukr[1]; valueUkr_Rus[1] = keyRus[1];
            valueRus_Ukr[2] = "сонце"; keyUkr[2] = valueRus_Ukr[2]; valueUkr_Rus[2] = keyRus[2];
            valueRus_Ukr[3] = "яблуко"; keyUkr[3] = valueRus_Ukr[3]; valueUkr_Rus[3] = keyRus[3];
            valueRus_Ukr[4] = "стіл"; keyUkr[4] = valueRus_Ukr[4]; valueUkr_Rus[4] = keyRus[4];

            valueUkr_Eng[0] = valueRus_Eng[0]; valueEng_Ukr[0] = keyUkr[0];
            valueUkr_Eng[1] = valueRus_Eng[1]; valueEng_Ukr[1] = keyUkr[1];
            valueUkr_Eng[2] = valueRus_Eng[2]; valueEng_Ukr[2] = keyUkr[2];
            valueUkr_Eng[3] = valueRus_Eng[3]; valueEng_Ukr[3] = keyUkr[3];
            valueUkr_Eng[4] = valueRus_Eng[4]; valueEng_Ukr[4] = keyUkr[4];
        }

        public string this[string word, string translate]
        {
            get
            {
                if (translate == "Rus_Eng")
                {
                    for (int i = 0; i < keyRus.Length; i++)
                    {
                        if (keyRus[i] == word)
                        {
                            return keyRus[i] + " - " + valueRus_Eng[i];
                        }
                    }
                }
                if (translate == "Eng_Rus")
                {
                    for (int i = 0; i < keyEng.Length; i++)
                    {
                        if (keyEng[i] == word)
                        {
                            return keyEng[i] + " - " + valueEng_rus[i];
                        }
                    }
                }
                if (translate == "Eng_Ukr")
                {
                    for (int i = 0; i < keyEng.Length; i++)
                    {
                        if (keyEng[i] == word)
                        {
                            return keyEng[i] + " - " + valueEng_Ukr[i];
                        }
                    }
                }
                if (translate == "Ukr_Eng")
                {
                    for (int i = 0; i < keyUkr.Length; i++)
                    {
                        if (keyUkr[i] == word)
                        {
                            return keyUkr[i] + " - " + valueUkr_Eng[i];
                        }
                    }
                }
                if (translate == "Ukr_Rus")
                {
                    for (int i = 0; i < keyUkr.Length; i++)
                    {
                        if (keyUkr[i] == word)
                        {
                            return keyUkr[i] + " - " + valueUkr_Rus[i];
                        }
                    }
                }
                if (translate == "Rus_Ukr")
                {
                    for (int i = 0; i < keyRus.Length; i++)
                    {
                        if (keyRus[i] == word)
                        {
                            return keyRus[i] + " - " + valueRus_Ukr[i];
                        }
                    }
                }
                return string.Format("{0} - нет перевода для этого слова.", word);
            }
        }

        public string this[int word]
        {
            get
            {
                if (word >= 0 && word < keyRus.Length)
                    return keyRus[word] + " - " + valueRus_Eng[word]+ "   " +keyRus[word] + " - " + valueRus_Ukr[word] + "   " + keyUkr[word] + " - " + valueUkr_Eng[word] + "   " + keyUkr[word] + " - " + valueUkr_Rus[word] + "   " + keyEng[word] + " - " + valueEng_Ukr[word] + "   " + keyEng[word] + " - " + valueEng_rus[word];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
