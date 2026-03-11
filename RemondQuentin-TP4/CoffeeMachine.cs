using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemondQuentin_TP4
{
    public class CoffeeMachine
    {
        private string code;
        private double money;
        private int coffeeLeft;
        private int sugarLeft;
        private int waterLeft;
        private string name;
     
        public int CoffeeLeft { get => coffeeLeft;}
        public int SugarLeft { get => sugarLeft;}
        public int WaterLeft { get => waterLeft;}
        public string Name { get => name; set => name = value; }

        public CoffeeMachine (string code, string name)
        {
            this.code = code;
            this.name = name;
            this.money = 0;
            this.coffeeLeft = 0;
            this.sugarLeft = 0;
            this.waterLeft = 0;
        }

        public void ReloadWater(int quantity)
        {
            this.waterLeft += quantity;
        }
        public void ReloadSugar(int nb)
        {
            this.sugarLeft += nb;
        }
        public void ReloadCoffee(int nb)
        {
            this.coffeeLeft += nb;
        }

        public Distribution? GiveCoffee (Boolean longCoffee, int sugar)
        {
            if (longCoffee)
            {
                if (this.waterLeft >= 70)
                {
                    if (this.coffeeLeft >= 2)
                    {
                        if (this.sugarLeft >= sugar)
                        {
                            Distribution? distrib = new Distribution(2, 70, sugar);
                            this.waterLeft -= 70;
                            this.coffeeLeft -= 2;
                            this.sugarLeft -= sugar;
                            this.money += distrib.Cost;
                            return distrib;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (this.waterLeft >= 30)
                {
                    if (this.coffeeLeft >= 1)
                    {
                        if (this.sugarLeft >= sugar)
                        {
                            Distribution? distrib = new Distribution(1, 30, sugar);
                            this.waterLeft -= 30;
                            this.coffeeLeft -= 1;
                            this.sugarLeft -= sugar;
                            this.money += distrib.Cost;
                            return distrib;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public double TakeMoney()
        {
            double rendu=this.money;
            this.money = 0;
            return rendu;
        }
    }
}
