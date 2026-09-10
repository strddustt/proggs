using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PlayerInfo
    {
        internal string playerName = "meow";
        internal int score = 100;
        internal bool alive = true;
        internal int hp = 100;
    }
    public class Arrays
    {
        internal string[] enemies = { "Orc", "Knight", "Wizard", "Ogre", "Dragon" };
        internal int[] ints = { 25, 4810, 346, 2350, 1 };
        internal int currenthighest;
    }
    public class Program
    {
        static void Main( string[] args)
        {
            Program program = new Program();
            PlayerInfo info = new PlayerInfo();
            Arrays arrays = new Arrays();
            Console.WriteLine(info.playerName);
            info.hp -= 35;
            Console.WriteLine(info.hp);
            if (info.hp > 0)
            {
                Console.WriteLine("player's alive");
            }
            Console.WriteLine(program.HighestInt(36, 116));
            Console.WriteLine(program.CalculateDamage(1500, 200));
            for(int i = 0; i < arrays.enemies.Length; i++)
            {
                Console.WriteLine(arrays.enemies[i]);
            }
            
            for(int i = 0; i < arrays.ints.Length; i++)
            {
                if (arrays.ints[i] > arrays.currenthighest)
                {
                    arrays.ints[i] = arrays.currenthighest;
                }
            }
            Console.WriteLine(arrays.currenthighest);
        }
        internal int HighestInt(int a, int b)
        {
            if (a > b) 
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        internal int CalculateDamage(int damage, int defense)
        {
            if (damage - defense > 0)
            {
                return damage - defense;
            }
            else
            {
                return 0;
            }
        }
    }
}
