using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Мясо", "Будка", "Хаски");
            Cat cat = new Cat("Корм", "Дом", "Британская");
            Horse horse = new Horse("Сено", "Стойло", "Гнедая");

            Veterinarian veterinarian = new Veterinarian();

            veterinarian.TreatAnimal(dog);
            veterinarian.TreatAnimal(cat);
            veterinarian.TreatAnimal(horse);
        }
    }
    public abstract class Animal
    {
        public string Food { get; set; }
        public string Location { get; set; }
        public string Breed { get; set; }

        public Animal(string food, string location, string breed)
        {
            Food = food;
            Location = location;
            Breed = breed;
        }
        public abstract string MakeNoise();
        public abstract string Eat();
        public abstract string Sleep();
    }
    public class Dog : Animal
    {

        public Dog(string food, string location, string breed) : base(food, location, breed)
        {
        }

        public override string MakeNoise()
        {
            return "Собака лает";
        }

        public override string Eat()
        {
            return "Собака ест " + Food;
        }
        public override string Sleep()
        {
            return "Собака спит";
        }
    }
    public class Cat : Animal
    {

        public Cat(string food, string location, string breed) : base(food, location, breed)
        {
        }

        public override string MakeNoise()
        {
            return "Кошка мяукает";
        }

        public override string Eat()
        {
            return "Кошка ест " + Food;
        }
        public override string Sleep()
        {
            return "Кошка спит";
        }
    }

    public class Horse : Animal
    {

        public Horse(string food, string location, string breed) : base(food, location, breed)
        {
        }

        public override string MakeNoise()
        {
            return "Лошадь ржет";
        }

        public override string Eat()
        {
            return "Лошадь ест " + Food;
        }
        public override string Sleep()
        {
            return "Лошадь спит";
        }
    }
    public class Veterinarian
    {
        public void TreatAnimal(Animal animal)
        {
            Console.WriteLine($"Еда: {animal.Food}, местоположение: {animal.Location}, порода {animal.Breed}");
        }
    }
}