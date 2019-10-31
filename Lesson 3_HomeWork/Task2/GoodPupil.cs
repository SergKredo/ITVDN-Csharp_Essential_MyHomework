using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GoodPupil:Pupil
    {
        string pupilOne;
        string pupilTwo;
        string pupilThree;
        string pupilFour;
        public string goodPupil = "Good";
        public GoodPupil(string pupilOne, string pupilTwo, string pupilThree, string pupilFour)
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
                if (goodPupil == base.pupils[i])
                {
                    sum++;
                    GoodPupil goodPupil = new GoodPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(goodPupil.pupils[i] + ", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (goodPupil != base.pupils[i] && sum == 0)
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
                if (goodPupil == base.pupils[i])
                {
                    sum++;
                    GoodPupil goodPupil = new GoodPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(goodPupil.pupils[i]+", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (goodPupil != base.pupils[i] && sum == 0)
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
                if (goodPupil == base.pupils[i])
                {
                    sum++;
                    GoodPupil goodPupil = new GoodPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(goodPupil.pupils[i] + ", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (goodPupil != base.pupils[i] && sum == 0)
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
                if (goodPupil == base.pupils[i])
                {
                    sum++;
                    GoodPupil goodPupil = new GoodPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
                    Console.Write(goodPupil.pupils[i] + ", ");
                }
                if (i != (pupils.Length - 1))
                {
                    continue;
                }
                else if (goodPupil != base.pupils[i] && sum == 0)
                {
                    Console.Write("No one");
                }
            }
            Console.WriteLine();

        }
    }
}
