using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_cpts_487
{
    public class ZombieFactory
    {
        public IZombie createRegularZombie()
        {
            IZombie newZombie = new Zombie();
            IZombie regZombie = new ZDRegular(newZombie);
            return regZombie;
        }
        public IZombie createConeZombie()
        {
            IZombie newZombie = new Zombie();
            IZombie coneZombie = new ZDCone(newZombie);
            return coneZombie;
        }
        public IZombie createBucketZombie()
        {
            IZombie newZombie = new Zombie();
            IZombie bucketZombie = new ZDBucket(newZombie);
            return bucketZombie;
        }
        public IZombie createScreenDoorZombie()
        {
            IZombie newZombie = new Zombie();
            IZombie doorZombie = new ZDDoor(newZombie);
            return doorZombie;
        }
    }
}
