using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyClassLib.World_of_Tanks;
namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)//играть в дебаге c точкой в program (здесь) 
        {
            Tank tank1= new Tank("Dantes",TankModel.Nikler);//французы
            tank1.printInfo();
            Console.WriteLine("------------------------------");

            Tank tank2 = new Tank("Pushkin",TankModel.T34);//русские
            tank2.printInfo();
            Thread.Sleep(3000);
             Console.Clear();
            Console.WriteLine("------------WINNER------------");
            (tank1 ^ tank2).printInfo();
            
        }
    }
}
