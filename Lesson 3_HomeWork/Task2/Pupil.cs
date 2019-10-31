using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        public string[] pupils = new string[4];
        public Pupil(string pupilOne, string pupilTwo, string pupilThree, string pupilFour)
        {
            pupils[0] = pupilOne;
            pupils[1] = pupilTwo;
            pupils[2] = pupilThree;
            pupils[3] = pupilFour;
        }
        public virtual void Study()
        {
            pupils[0] = "Good";
            pupils[1] = "Bad";
            pupils[2] = "Excellent";
            pupils[3] = "Good";


        }
        public virtual void Read()
        {
            pupils[0] = "Excellent";
            pupils[1] = "Good";
            pupils[2] = "Excellent";
            pupils[3] = "Good";
        }
        public virtual void Write()
        {
            pupils[0] = "Good";
            pupils[1] = "Good";
            pupils[2] = "Excellent";
            pupils[3] = "Excellent";

        }
        public virtual void Relax()
        {
            pupils[0] = "Bad";
            pupils[1] = "Good";
            pupils[2] = "Bad";
            pupils[3] = "Excellent";

        }
    }
}
