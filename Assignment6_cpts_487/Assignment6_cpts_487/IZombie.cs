using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_cpts_487
{
    public interface IZombie
    {
        public string getZombieType();
        public double getZombieHealth();
        public double getZombieSpeed();
        public double getZombieDefence();
        public bool getIsMetal();
        public bool getIsCovered();
        public void setZombieType(string input);
        public void setZombieHealth(double input);
        public void setZombieSpeed(double input);
        public void setZombieDefence(double input);
        public void setZombieIsMetal(bool input);
        public void setZombieIsCovered(bool input);
    }
}
