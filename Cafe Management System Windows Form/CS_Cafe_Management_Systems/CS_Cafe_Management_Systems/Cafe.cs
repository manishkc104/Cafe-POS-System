using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Cafe_Management_Systems
{
    class Cafe
    {
        public Cafe()
        {
            //Intializationfor coffee
            newLatte_cof = 0;
            newchkEspresso_cof = 0;
            newicedLatte_cof = 0;
            newvaleCoffee_cof = 0;
            newcappuccino_cof = 0;
            newafricanCoffee_cof = 0;
            newmaearicanCoffee_cof = 0;
            newicedCappuccino_cof = 0;


            newcoffeeCake_cak = 0;
            newblackForestCake_cak = 0;
            newbostonCreamCake_cak = 0;
            newlagosChocolateCake_cak = 0;
            newkillburnChocolateCake_cak = 0;
            newcarltonHillChocolateCake_cak = 0;
            newqueensParkChocolateCake_cak = 0;

        }
        public Cafe(double latte_cof, double chkEspresso_cof, double icedLatte_cof, double valeCoffee_cof, double cappuccino_cof, double africanCoffee_cof, double americanCoffee_cof, double icedCappuccino_cof, double coffeeCake_cak, double redVelvetCake_cak, double blackForestCake_cak, double bostonCreamCake_cak, double lagosChocolateCake_cak, double killburnChocolateCake_cak, double carltonHillChocolateCake_cak, double queensParkChocolateCake_cak)
        {
            //Coffee
            newLatte_cof = latte_cof;
            newchkEspresso_cof = chkEspresso_cof;
            newicedLatte_cof = icedLatte_cof;
            newvaleCoffee_cof = valeCoffee_cof;
            newcappuccino_cof = cappuccino_cof;
            newafricanCoffee_cof = africanCoffee_cof;
            newicedCappuccino_cof = icedCappuccino_cof;

            newcoffeeCake_cak = coffeeCake_cak;
            newblackForestCake_cak = blackForestCake_cak;
            newbostonCreamCake_cak = bostonCreamCake_cak;
            newlagosChocolateCake_cak = lagosChocolateCake_cak;
            newkillburnChocolateCake_cak = killburnChocolateCake_cak;
            newcarltonHillChocolateCake_cak = carltonHillChocolateCake_cak;
            newqueensParkChocolateCake_cak = queensParkChocolateCake_cak;



        }
        //Member variable declared for coffee 
        private double newLatte_cof { get; set; }
        private double newchkEspresso_cof { get; set; }
        private double newicedLatte_cof { get; set; }
        private double newvaleCoffee_cof { get; set; }
        private double newcappuccino_cof { get; set; }
        private double newafricanCoffee_cof { get; set; }
        private double newmaearicanCoffee_cof { get; set; }
        private double newicedCappuccino_cof { get; set; }

        //Mmeber variable for cake
        private double newcoffeeCake_cak { get; set; }
        private double newredVelvetCake_cak { get; set; }
        private double newblackForestCake_cak { get; set; }
        private double newbostonCreamCake_cak { get; set; }
        private double newlagosChocolateCake_cak { get; set; }
        private double newkillburnChocolateCake_cak { get; set; }
        private double newcarltonHillChocolateCake_cak { get; set; }
        private double newqueensParkChocolateCake_cak { get; set; }

    }
}
