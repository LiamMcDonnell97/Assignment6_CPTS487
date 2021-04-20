using System;
using System.Collections.Generic;
using System.Threading;

namespace Assignment6_cpts_487
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoPlantsVsZombies run = new DemoPlantsVsZombies();
        }
    }

    public class DemoPlantsVsZombies
    {
        ZombieFactory zombieCreator = new ZombieFactory();
        List<IZombie> ZombieList = new List<IZombie>();
        public DemoPlantsVsZombies()
        {
            RunGame();
        }

        void RunGame()
        {
            string option = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1. Create zombies?");
                Console.WriteLine("2. Demo game play?");
                Console.WriteLine("3. Exit?");
                if (ZombieList.Count > 0)
                {
                    Console.WriteLine("");
                    printZombieList();
                }
                option = Console.ReadLine();
                if (option == "1")
                {
                    addZombie();
                }
                if (option == "2")
                {
                    demoGame();
                }


            } while (option != "3");
            Console.WriteLine("Thankyou for playing!");
        }

        public void addZombie()
        {
            int option = 0;
            Console.WriteLine("Which kind?");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Cone");
            Console.WriteLine("3. Bucket");
            Console.WriteLine("4. ScreenDoor");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ZombieList.Add(zombieCreator.createRegularZombie());
                    break;
                case 2:
                    ZombieList.Add(zombieCreator.createConeZombie());
                    break;
                case 3:
                    ZombieList.Add(zombieCreator.createBucketZombie());
                    break;
                case 4:
                    ZombieList.Add(zombieCreator.createScreenDoorZombie());
                    break;
            }
        }

        void printZombieList()
        {
            Console.Write("[");
            for (int i = 0; i < ZombieList.Count; i++)
            {
                Console.Write(ZombieList[i].getZombieType() + "/" + ZombieList[i].getZombieHealth().ToString());
                if (i != ZombieList.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        void demoGame()
        {
            string plantOption = "";
            int option = 0;
            double peaShooterHealth = 100;
            double peaShooterDamage = 25;
            int zombieOnBoard = 0;
            string[] gameBoard = { "HOUSE: ", "P/100", "__", "__", "__", "__", "__", "__", "__", "__", "__" };
            // select damage for peaShooter
            while (true)
            {
                Console.WriteLine("Please select damage for peaShooter:");
                Console.WriteLine("1. 25 damage");
                Console.WriteLine("2. 40 damage");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    peaShooterDamage = 25;
                    break;
                }
                else if (option == 2)
                {
                    peaShooterDamage = 40;
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT: select 1 or 2");
                }

            }
            //master demo loop
            while (ZombieList.Count > 0)
            {
                Console.WriteLine("enter 1 to shoot watermellon, enter 2 to activate mushroom, enter nothing to shoot regular peaShooter.");
                plantOption = Console.ReadLine();
                //add next zombie to gameBoard
                if (gameBoard[gameBoard.Length - 1] == "__" && zombieOnBoard == 0)
                {
                    gameBoard[gameBoard.Length - 1] = ZombieList[0].getZombieType() + "/" + ZombieList[0].getZombieHealth().ToString();
                    zombieOnBoard = 1;
                }
                //shoot first zombie in order
                if(plantOption == "1")
                {
                    if(ZombieList[0].getZombieType() == "S")
                    {
                        ZombieList[0] = zombieCreator.createRegularZombie();
                        Console.WriteLine("Screen zombie hit with watermellon, changed to RegularZombie!");
                    }
                }
                if(plantOption == "2")
                {
                    if(ZombieList[0].getZombieType() == "S" || ZombieList[0].getZombieType() == "B")
                    {
                        ZombieList[0] = zombieCreator.createRegularZombie();
                        Console.WriteLine("Metal zombie effected by mushroom, changed to RegularZombie!");
                    }
                }
                else 
                {
                    ZombieList[0].setZombieHealth(ZombieList[0].getZombieHealth() - peaShooterDamage);
                }
                //if zombie is not already regular and health becomes 50 or below, convert to regular zombie
                if (ZombieList[0].getZombieHealth() <= 50 && ZombieList[0].getZombieType() != "R")
                {
                    ZombieList[0] = zombieCreator.createRegularZombie();
                    Console.WriteLine("Zombie changed to RegularZombie!");
                }
                //if zombies health falls at or below 0, remove zombie(kill zombie)
                if (ZombieList[0].getZombieHealth() <= 0)
                {
                    for (int pos = 2; pos < gameBoard.Length; pos++)
                        if (gameBoard[pos] != "__")
                        {
                            gameBoard[pos] = "__";
                            break;
                        }
                    ZombieList.RemoveAt(0);
                    Console.WriteLine("Zombie Killed!");
                    zombieOnBoard = 0;
                }
                //print game board
                printGameBoard(gameBoard);
                //print zombie list
                printZombieList();
                //advance zombie on gameBoard
                for (int position = gameBoard.Length - 1; position > 2; position--)
                {
                    if (gameBoard[position] != "__")
                    {
                        gameBoard[position - 1] = gameBoard[position];
                        gameBoard[position] = "__";
                        break;
                    }
                }

            }
            Console.Clear();
            Console.WriteLine("Congrats! you beat the zombies!");
            Thread.Sleep(2000);
            Console.Clear();

        }

        void printGameBoard(string[] gameBoard)
        {
            Console.Write("\n");
            for (int i = 0; i < gameBoard.Length; i++)
            {
                Console.Write(gameBoard[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
