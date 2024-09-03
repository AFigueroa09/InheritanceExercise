using Inheritance.Classes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird parrot = new Bird();
            parrot.Name = "African Grey Parrot";
            parrot.Color = "grey, white and red";
            parrot.EggWeight = 1.2;
            parrot.Song = "Loud";
            parrot.FeatherLength = 3;
            parrot.WeekOfFirstFlight = 64;
            Console.WriteLine($"The {parrot.Name} is a {parrot.Song} bird. Baby {parrot.Name} will be able to fly during their {parrot.WeekOfFirstFlight}th week. It's Egg weight {parrot.EggWeight}g. Each feather can measure up to {parrot.FeatherLength}in long.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.Name = "Black Mamba";
            snake.LegCount = 0;
            snake.Color = "black";
            snake.IsNocturnal = true;
            snake.IsUnderground = true;
            snake.IsPoisonous = true;
            snake.EggWeight = 0.6;

            var poison = snake.IsPoisonous ? "poisonous" : "non-poisonous";
            var timeofActive = snake.IsNocturnal ? "night" : "day";

            Console.WriteLine($"The {snake.Name} is a {poison} reptile that is active mostly during the {timeofActive}. It's scales are colored {snake.Color}. It's Egg weight {snake.EggWeight}g.");
        }
    }
}
