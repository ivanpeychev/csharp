using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{ 
    static void Main()
    {
        Human Gosho = new Human("Gosho");
        Gosho.Weapon.Name = "Axe";
        Gosho.Weapon.AttackPower = 30;
        Gosho.Shield.Name = "Shield of destiny";
        Gosho.Shield.DefencePoints = 15;


        Orc Stavri = new Orc("Stavri");
        Stavri.Weapon.Name = "Club";
        Stavri.Weapon.AttackPower = 30;
        Stavri.Shield.Name = "Toilet cover";
        Stavri.Shield.DefencePoints = 50;


        Gosho.PrintStats();

        Stavri.PrintStats();

        Gosho.Health = 100;
    }
}