using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_cpts_487
{
    class ZombieDecorator : IZombie
    {
        private IZombie _zombie;

        public ZombieDecorator(IZombie NIZombie)
        {
            this._zombie = NIZombie;
        }
        public virtual string getZombieType()
        {
            return _zombie.getZombieType();
        }

        public virtual double getZombieHealth()
        {
            return _zombie.getZombieHealth();
        }

        public virtual double getZombieSpeed()
        {
            return _zombie.getZombieSpeed();
        }

        public virtual double getZombieDefence()
        {
            return _zombie.getZombieDefence();
        }

        public virtual bool getIsMetal()
        {
            return _zombie.getIsMetal();
        }

        public virtual bool getIsCovered()
        {
            return _zombie.getIsCovered();
        }

        public virtual void setZombieType(string input)
        {
            _zombie.setZombieType(input);
        }
        public virtual void setZombieHealth(double input)
        {
            _zombie.setZombieHealth(input);
        }
        public virtual void setZombieSpeed(double input)

        {
            _zombie.setZombieSpeed(input);
        }

        public virtual void setZombieDefence(double input)
        {
            _zombie.setZombieDefence(input);
        }

        public virtual void setZombieIsMetal(bool input)
        {
            _zombie.setZombieIsMetal(input);
        }

        public virtual void setZombieIsCovered(bool input)
        {
            _zombie.setZombieIsCovered(input);
        }
    }
}
