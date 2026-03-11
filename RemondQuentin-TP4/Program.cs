using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RemondQuentin_TP4
{
    public class Program
    {
        static void Main(string[] args)
        { 
            int count = 0;
            CoffeeMachine bob = new CoffeeMachine("IUT001", "K-fé IUT");
            bob.ReloadWater(1000);
            bob.ReloadCoffee(30);
            bob.ReloadSugar(40);
            bob.Name = "Café";
            Console.WriteLine($"Le nom de ce disttributeur est {bob.Name}");
            bob.GiveCoffee(false, 0);
            bob.GiveCoffee(true, 2);
            bob.GiveCoffee(true, 2);
            bob.GiveCoffee(true, 2);
            Console.WriteLine($"La monnaie reprise après un café court non sucré et 3 cafés longs avec 2 doses de sucre est de {bob.TakeMoney()} euros");
            for (int i = 0; i < 11; i++)
            {
                if (bob.GiveCoffee(true, 2) != null)
                {
                    count++;
                }               
            }
            Console.WriteLine($"Le nombre de café ayant été distribué est de {count}");
            Console.WriteLine($"La monnaie reprise après {count} cafés longs avec 2 doses de sucre est de {bob.TakeMoney()} euros");
            bob.ReloadWater(30);
            bob.ReloadCoffee(1);
            bob.ReloadSugar(10);
            if (bob.GiveCoffee(false, 1) != null)
            {
                Console.WriteLine("Café court avec 1 dose de sucre bien distribué !");
            }
        }
    }
}
