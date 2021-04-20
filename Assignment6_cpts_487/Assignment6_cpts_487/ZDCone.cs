using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_cpts_487
{
    class ZDCone : ZombieDecorator
    {
        public ZDCone(IZombie _zombie) : base(_zombie)
        {
            _zombie.setZombieType("C");
            _zombie.setZombieHealth(75);
            _zombie.setZombieDefence(1);
            _zombie.setZombieSpeed(1);
            _zombie.setZombieIsMetal(false);
            _zombie.setZombieIsCovered(false);
        }

        public override string getZombieType()
        {
            return base.getZombieType();
        }

        public override double getZombieHealth()
        {
            return base.getZombieHealth();
        }

        public override double getZombieSpeed()
        {
            return base.getZombieSpeed();
        }

        public override double getZombieDefence()
        {
            return base.getZombieDefence();
        }

        public override bool getIsMetal()
        {
            return base.getIsMetal();
        }

        public override bool getIsCovered()
        {
            return base.getIsCovered();
        }
        public override void setZombieType(string input)
        {
            base.setZombieType(input);
        }
        public override void setZombieHealth(double input)
        {
            base.setZombieHealth(input);
        }
        public override void setZombieSpeed(double input)

        {
            base.setZombieSpeed(input);
        }

        public override void setZombieDefence(double input)
        {
            base.setZombieDefence(input);
        }

        public override void setZombieIsMetal(bool input)
        {
            base.setZombieIsMetal(input);
        }

        public override void setZombieIsCovered(bool input)
        {
            base.setZombieIsCovered(input);
        }
    }
}
