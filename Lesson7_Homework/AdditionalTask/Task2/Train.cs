using System;

namespace Task2
{
    struct Train
    {
        string[] destination;
        int[] numberTrain;
        string[] dataTime;
        DateTime departureTime;
        Random random;

        public Train(string[] destination, int[] numberTrain, string[] dataTime, int numberRandom)
        {
            this.random = new Random();
            int number = random.Next(1, numberRandom);
            int dataTimeHours, dataTimeMinutes, dataTimeSeconds;
            this.departureTime = new DateTime();
            this.destination = destination;
            this.numberTrain = numberTrain;
            this.dataTime = dataTime;
            for (int i = 0; i < numberTrain.Length; i++)
            {
                number = random.Next(1, numberRandom);
                dataTimeHours = this.random.Next(0, 24);
                dataTimeMinutes = this.random.Next(0, 60);
                dataTimeSeconds = this.random.Next(0, 60);
                this.departureTime = new DateTime(2019, 09, 24, dataTimeHours, dataTimeMinutes, dataTimeSeconds);

                this.numberTrain[i] = number;
                this.dataTime[i] = Convert.ToString(departureTime);

            }

            destination[0] = "Kyiv"; destination[1] = "Lviv"; destination[2] = "Minsk"; destination[3] = "Moscov";
            destination[4] = "Odessa"; destination[5] = "Zaporizza"; destination[6] = "Chernovtci"; destination[7] = "Kherson";

            Array.Sort(this.numberTrain);

        }

        public string this[int index]
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < numberTrain.Length; i++)
                {
                    if (index == numberTrain[i])
                    {
                        ++sum;
                        return ShowSimpleTrain(index);
                    }
                }
                if (sum == 0)
                {
                    Console.WriteLine("Такой номер поезда отсутствует в системе!");
                    return null;
                }
                return null;

            }
        }

        public void ShowTrain()
        {
            for (int i = 0; i < numberTrain.Length; i++)
            {
                Console.WriteLine("Destination: " + destination[i] + ";\n" + "Number of train: " + numberTrain[i] + ";\n" + "Departure time: " + dataTime[i] + ";\n");
            }
        }

        public string ShowSimpleTrain(int index)
        {
            for (int i = 0; i < numberTrain.Length; i++)
            {
                if (index == numberTrain[i])
                {
                    return "\nDestination: " + destination[i] + ";\n" + "Number of train: " + numberTrain[i] + ";\n" + "Departure time: " + dataTime[i] + ";\n";
                }
            }
            return null;
        }



    }
}

