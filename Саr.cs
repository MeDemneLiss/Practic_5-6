namespace Practic_5
{
    class Car
    {
        public string Tredemark { get; set; }
        public int Power { get; set; }
        public double NumberCylinders { get; set; }

        public Car()
        {
            Tredemark = string.Empty;
            Power = 0;
            NumberCylinders = 0;
        }
        public Car SetParams(string inName)
        {
            Tredemark = inName;
            return this;
        }
        public Car SetParams(double inWeight)
        {
            NumberCylinders = inWeight;
            return this;
        }
        public Car SetParams(int inHowOld)
        {
            Power = inHowOld;
            return this;
        }

        public string ShowInformation()
        {
            string info = "Торговая марка - " + Tredemark + "\n" + "Мощность - " + Power + " л.с.\n" + "Колличество цилиндров - " + NumberCylinders;
            return info;
        }

        //6 Практическая
        public static Car operator ++(in Car carNumberOne)
        {
            carNumberOne.Power += 1;
            return carNumberOne;
        }

        public static bool operator >(Car carNumberOne, Car carNumberTwo)
        {
            bool result = (carNumberOne.Power > carNumberTwo.Power && carNumberOne.NumberCylinders > carNumberTwo.NumberCylinders) || (carNumberOne.Power > carNumberTwo.Power && carNumberOne.NumberCylinders == carNumberTwo.NumberCylinders) || (carNumberOne.Power == carNumberTwo.Power && carNumberOne.NumberCylinders > carNumberTwo.NumberCylinders);
            return result;
        }

        public static bool operator <(Car carNumberOne, Car carNumberTwo)
        {
            bool result = carNumberOne.Power < carNumberTwo.Power && carNumberOne.NumberCylinders < carNumberTwo.NumberCylinders || carNumberOne.Power < carNumberTwo.Power && carNumberOne.NumberCylinders == carNumberTwo.NumberCylinders || carNumberOne.Power == carNumberTwo.Power && carNumberOne.NumberCylinders < carNumberTwo.NumberCylinders;
            return result;
        }
    }

}

