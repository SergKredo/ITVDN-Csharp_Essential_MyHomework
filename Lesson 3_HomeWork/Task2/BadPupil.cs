using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BadPupil:Pupil
    {
        string pupilOne;
        string pupilTwo;
        string pupilThree;
        string pupilFour;
        public string badPupil = "Bad";
        public BadPupil(string pupilOne, string pupilTwo, string pupilThree, string pupilFour)
            : base(pupilOne, pupilTwo, pupilThree, pupilFour)
        {
            this.pupilOne = pupilOne;
            this.pupilTwo = pupilTwo;
            this.pupilThree = pupilThree;
            this.pupilFour = pupilFour;

        }
        public override void Read()
        {
            base.Read();
            Console.Write("- читают: ");
            int sum = 0;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (badPupil == base.pupils[i])
                {
                    sum++;
                    BadPupil badPupil = new BadPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(badPupil.pupils[i] + ", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (badPupil != base.pupils[i] && sum == 0)
                {
                    Console.Write("No one");
                }
            }
            Console.WriteLine();
        }
        public override void Study()
        {
            base.Study();
            Console.Write("- учатся: ");
            int sum = 0;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (badPupil == base.pupils[i])
                {
                    sum++;
                    BadPupil badPupil = new BadPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(badPupil.pupils[i]+", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (badPupil != base.pupils[i] && sum == 0)
                {
                    Console.Write("No one");
                }
            }
            Console.WriteLine();
        }
        public override void Write()
        {
            base.Write();
            Console.Write("- пишут: ");
            int sum = 0;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (badPupil == base.pupils[i])
                {
                    sum++;
                    BadPupil badPupil = new BadPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(badPupil.pupils[i] + ", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (badPupil != base.pupils[i] && sum == 0)
                {
                    Console.Write("No one");
                }
            }
            Console.WriteLine();
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("- отдыхают: ");
            int sum = 0;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (badPupil == base.pupils[i])
                {
                    sum++;
                    BadPupil badPupil = new BadPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(badPupil.pupils[i] + ", ");
                
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (badPupil != base.pupils[i] && sum == 0)
                {
                    Console.Write("No one");
                }
            }
            Console.WriteLine();

        }
    }
}
