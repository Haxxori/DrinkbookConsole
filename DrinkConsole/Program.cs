using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink();

            Console.Write("Nimi: ");
            drink.RecipeName = Console.ReadLine();
            Console.Write("Tyyppi: ");
            drink.RecipeType = Console.ReadLine();
            Console.Write("Aineosat: ");
            drink.RecipeIngredients = Console.ReadLine();
            Console.Write("Ohje: ");
            drink.RecipeInfo = Console.ReadLine();



            Console.WriteLine("--------------------------");

            Console.WriteLine("Nimi: " + drink.RecipeName);
            Console.WriteLine("Tyyppi: " + drink.RecipeType);
            Console.WriteLine("Raaka-aineet: " + drink.RecipeIngredients);
            Console.WriteLine("Ohje: " + drink.RecipeInfo);

            Console.ReadLine();
        }
    }
}
