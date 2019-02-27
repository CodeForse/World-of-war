using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.World_of_Tanks
{
    
    public enum TankModel { T34 , Pantera,Tigger,Nikler}
    public class Tank
    {
        
        public string name { get; set; }
        private int strength;
        private int agility;
        private int health;
        public TankModel TankModel { get; set; }
        public Tank(string name, TankModel model)
        { 
            try
            {
               
                this.name = name;
                this.TankModel = model;

                this.health = rnd.Next(0, 100);
                this.strength = rnd.Next(0, 100);
                this.agility = rnd.Next(0, 100);
           
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Random rnd = new Random((int)DateTime.Now.Ticks);
        public string getInfo()
        {
            string res = name + ";"
                + TankModel.ToString() + ";"
                + "strength:" + strength.ToString() + ";"
                + "agility:" + agility.ToString() + ";"
                + "health:" + health.ToString() + ";";
            return res;
        }
        public void printInfo()
        {
            Console.WriteLine("-------{0}-------",this.name);
            Console.WriteLine("Tank model : {0}",TankModel);
            Console.WriteLine("Strength : {0}\nAgility : {1}\nHealth : {2}",this.strength,this.agility,this.health);
        }

           public static Tank operator ^(Tank f,Tank s)
        {
            int Fpoints = 0, Spoints = 0 ;
            if (f.health > s.health) Fpoints++;
            else if (f.health < s.health) Spoints++;

            if (f.agility > s.agility) Fpoints++;
            else if (f.agility < s.agility) Spoints++;

            if (f.strength > s.strength) Fpoints++;
            else if (f.strength < s.strength) Spoints++;

            ////////////////////////////////////////

            if (Fpoints > Spoints)
                return f;
            else if (Spoints > Fpoints)
                return s;
            else
            {//'drop database Tanks--
                Tank tmp = new Tank("", TankModel.Tigger);

                return tmp;

            }
        } 
        
    }
}
