using System;
namespace CuteAnimal
{
    public class Cat
    {
        private string name;
        private HungryLevel hungry;
        private int energy;
        private MoodType mood;

        public void Meow()
        {
            Console.WriteLine("Meow...");
        }

        public void sleep()
        {
            energy += 20;
            if (energy > 100)
            {
                energy = 100;
            }
            hungry--;
            if (hungry < HungryLevel.hungry.hungry)
        }
    }
}