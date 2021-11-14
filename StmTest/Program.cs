using System;
using System.Collections.Generic;

namespace StmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //data driven approach
            var poemsFromProgram = GetAnimalsFromProgram();
            SingPoems(poemsFromProgram);

            var poemsFromUserInput = GetAnimalsFromUser();
            SingPoems(poemsFromUserInput);

            //Polymorphism approach
            Console.WriteLine(new Cow().Sing() + "\n");
            Console.WriteLine(new Cat().Sing() + "\n");
            Console.WriteLine(new Dog().Sing() + "\n");
            Console.WriteLine(new Duck().Sing() + "\n");
            Console.WriteLine(new Cock().Sing() + "\n");

            Console.ReadKey();
        }

        static List<Poem> GetAnimalsFromProgram()
        {
            return new List<Poem>()
            {
                new Poem("Cow", "moo"),
                new Poem("Dog", "woof"),
                new Poem("Cat", "meow"),
                new Poem("Duck", "quack"),
                new Poem("Cock", "crow"),
                //10 more animals
                new Poem("Bat", "screech"),
                new Poem("Deer", "bell"),
                new Poem("Dove", "coo"),
                new Poem("Bird", "chirp"),
                new Poem("Bear", "growl"),
                new Poem("Bee", "buzz"),
                new Poem("Frog", "croak"),
                new Poem("Goat", "bleat"),
                new Poem("Horse", "neigh"),
                new Poem("Pig", "snort"),
            };
        }

        static List<Poem> GetAnimalsFromUser()
        {
            var poems = new List<Poem>();
            Console.WriteLine("How many animals will you like to sing with?");
            var animalCountInput = int.Parse(Console.ReadLine());
            for (var i = 0; i < animalCountInput; i++)
            {
                Console.WriteLine($"Please enter the name of Animal {i + 1}");
                var animalNameInput = Console.ReadLine();
                Console.WriteLine($"Please enter the sound of a/an {animalNameInput}");
                var animalSoundInput = Console.ReadLine();
                poems.Add(new Poem(animalNameInput, animalSoundInput));
            }
            return poems;
        }

        static void SingPoems(List<Poem> poems)
        {
            foreach (var poem in poems)
            {
                Console.WriteLine(poem.Sing());
            }
        }
    }
}
