using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_cpts_487
{
    public class Zombie : IZombie
    {
        string name = "R";
        double health = 50;
        double speed = 1;
        double defence = 1;
        bool isMetal = false;
        bool isCovered = false;

        public Zombie(string nName, double nHealth, double nSpeed, double nDefence, bool nIsMetal, bool nIsCovered)
        {
            this.name = nName;
            this.health = nHealth;
            this.speed = nSpeed;
            this.defence = nDefence;
            this.isMetal = nIsMetal;
            this.isCovered = nIsCovered;
        }
        public Zombie()
        {

        }

        public string getZombieType()
        {
            return this.name;
        }
        
        public double getZombieHealth()
        {
            return this.health;
        }
        
        public double getZombieSpeed()
        {
            return this.speed;
        }
        
        public double getZombieDefence()
        {
            return this.defence;
        }

        public bool getIsMetal()
        {
            return this.isMetal;
        }

        public bool getIsCovered()
        {
            return this.isCovered;
        }

        public void setZombieType(string input)
        {
            this.name = input;
        }
        public void setZombieHealth(double input)
        {
            this.health = input;
        }
        public void setZombieSpeed(double input)
        
        {
            this.speed = input;
        }
        
        public void setZombieDefence(double input)
        {
            this.defence = input;
        }
        public void setZombieIsMetal(bool input)
        {
            this.isMetal = input;
        }
        public void setZombieIsCovered(bool input)
        {
            this.isCovered = input;
        }
    }
}
