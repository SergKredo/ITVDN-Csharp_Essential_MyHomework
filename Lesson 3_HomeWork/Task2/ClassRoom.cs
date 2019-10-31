using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        string pupilOne = "One";
        string pupilTwo = "Two";
        string pupilThree = "Three";
        string pupilFour = "Four";
        Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil pupilOne, Pupil pupilTwo, Pupil pupilThree, Pupil pupilFour)
            
        {
            pupils[0] = pupilOne;
            pupils[1] = pupilTwo;
            pupils[2] = pupilThree;
            pupils[3] = pupilFour;
            this.pupilOne = pupils[0].pupils[0];
            this.pupilTwo = pupils[1].pupils[1];
            this.pupilThree = pupils[2].pupils[2];
            this.pupilFour = pupils[3].pupils[3];
        }
        
        public void GoodPupils()
        {
            GoodPupil goodPupil = new GoodPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
            goodPupil.Study();
            goodPupil.Read();
            goodPupil.Write();
            goodPupil.Relax();
        }
        public void BadPupils()
        {
            BadPupil badPupil = new BadPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
            badPupil.Study();
            badPupil.Read();
            badPupil.Write();
            badPupil.Relax();
        }
        public void ExcelentPupils()
        {
            ExcelentPupil excelentPupil = new ExcelentPupil(pupilOne, pupilTwo, pupilThree, pupilFour);
            excelentPupil.Study();
            excelentPupil.Read();
            excelentPupil.Write();
            excelentPupil.Relax();
        }
    }
}
