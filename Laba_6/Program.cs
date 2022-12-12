using System;

namespace lab_6
{
    class Cat
    {
        enum Lab5Gender
        {
            Male,
            Female
        }

        public string Name
        { get; }
        Lab5Gender Gender
        { get; }

        private double _energy;
        public double Energy
        {
            get { return _energy; }
            set
            {
                if (_energy < MinEnergy)
                {
                    throw new ArithmeticException("Not enough energy to jump");
                }
                else if (_energy > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }

            }
        }

        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;
        public Cat(string name, Lab5Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }
        static void Jump()
        {
            Energy -= JumpEnergyDrain;
        }
        static void Sleep()
        {
            Energy += SleepEnergyGain;
        }
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Peri", Lab5Gender.Female);
            cat1.Jump();
            Console.WriteLine(cat1.Energy);
            cat1.Sleep();
        }
    }
}