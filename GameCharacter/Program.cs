using System;

namespace GameCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter character1 = new GameCharacter("Gander", "Warrior", "Slingshot", 10, 3);


            /* //Exercise 1:
             character1.Name = "Gander";
             character1.CharacterType = "Warrior";
             character1.WeaponOfChoice = "Slingshot";
             character1.Health = 10;
             character1.AttackPoints = 3; */

            string attack = character1.Attack();

            Console.WriteLine(attack);

            //Exercise 2:
            Enemy enemyObject = new Enemy(5, 10);


            /* enemyObject.AttackPoints = 5;
             enemyObject.Health = 10; */

            Console.WriteLine($"Game character health before attack is: {character1.Health}");

            character1.Health = enemyObject.ReduceCharacterHealth(character1);

            Console.WriteLine($"Game character health after attack is: {character1.Health}");

            //Challenge:
            Console.WriteLine($"Enemy health before attack is {enemyObject.Health}");
            enemyObject.Health = enemyObject.ReduceEnemiesHealth(character1);
            Console.WriteLine($"Enemy health after attack is {enemyObject.Health}");


            //Exercise 4:
            GameCharacter character2 = new GameCharacter("Ares", 20);
            Console.WriteLine(character2.GetHealthValue());

            //Challenge
            GameCharacter character3 = new GameCharacter("Zeus", "Lightning Rod");
            Console.WriteLine(character3.Attack());

            //Exercise 5: 
            Console.WriteLine(enemyObject.GetHealthValue());


            //Exercise 6: 
            character1.Health = Potions.IncreaseHealthBy10(character1.Health);

            Console.WriteLine(character1.GetHealthValue());

            //Challenge:
            enemyObject.Health = Potions.DecreaseHealthBy10(enemyObject.Health);

            Console.WriteLine(enemyObject.GetHealthValue());


            //Versus Game Challenge

            GameCharacter characterOne = new GameCharacter("Captain America", "Hero Soldier", "Shield", 100, 10);
            GameCharacter characterTwo = new GameCharacter("IronMan", "Billonaire Hero", "Suit of Iron", 75, 20);

            Enemy enemyOne = new Enemy(10, 30);
            Enemy bossEnemy = new Enemy(50, 30);

            Console.WriteLine("Welcome to the RPG Game. Please choose a character (1)Captain America (2)Ironman");
            string userChoice = "";
            GameCharacter userCharacter = null;

            bool isValid = false;
            while (isValid == false)
            {
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    userCharacter = characterOne;
                    isValid = true;

                }
                else if (userChoice == "2")
                {
                    userCharacter = characterTwo;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }

            Console.WriteLine("Here are your player stats:");
            Console.WriteLine($"Name: {userCharacter.Name}");
            Console.WriteLine($"Character Type: {userCharacter.CharacterType}");
            Console.WriteLine($"Weapon of Choice: {userCharacter.WeaponOfChoice}");
            Console.WriteLine($"Health: {userCharacter.Health}");
            Console.WriteLine($"Attack Points: {userCharacter.AttackPoints}");


            Console.WriteLine("Would you like to face (1)Enemy One or (2)Enemy Two");
            Enemy enemyChoice = null;

            isValid = false;
            string enemyNumber = "";
            while (isValid == false)
            {
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    enemyChoice = enemyOne;
                    enemyNumber = "enemy one";
                    isValid = true;

                }
                else if (userChoice == "2")
                {
                    enemyChoice = bossEnemy;
                    enemyNumber = "enemy two";
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }

            Console.WriteLine($"You are currently facing {enemyNumber} who has health of {enemyChoice.Health} and attack points of {enemyChoice.AttackPoints}");

            while (true)
            {
                if (userCharacter.Health > 0)
                {

                    Console.WriteLine("Choose an action (1)Attack (2)Use Heal Potion (3)Use Harm Potion on opponent");

                    string userAction = Console.ReadLine();

                    switch (userAction)
                    {
                        case "1":
                            
                                userCharacter.Attack();
                                enemyChoice.Health = enemyChoice.ReduceEnemiesHealth(userCharacter);
                                Console.WriteLine(enemyChoice.GetHealthValue());
                                
                            break;
                        case "2":
                            Console.WriteLine($"{userCharacter.Name} is using a heal potion.");
                            userCharacter.Health = Potions.IncreaseHealthBy10(userCharacter.Health);
                            Console.WriteLine(userCharacter.GetHealthValue());
                            break;
                        case "3":
                            Console.WriteLine($"{userCharacter.Name} is using a harm potion on the enemy.");
                            enemyChoice.Health = Potions.DecreaseHealthBy10(enemyChoice.Health);
                            Console.WriteLine(enemyChoice.GetHealthValue());
                            break;
                        default:
                            Console.WriteLine("Please choose a valid option");
                            break;
                    }

                    if (enemyChoice.Health > 0)
                    {
                        Console.WriteLine($"The enemy attacks with {enemyChoice.AttackPoints} points.");
                        userCharacter.Health = enemyChoice.ReduceCharacterHealth(userCharacter);
                        Console.WriteLine(userCharacter.GetHealthValue());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Enemy has been defeated");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine($"{userCharacter.Name} has been defeated");
                    break;
                }
            }

            Console.WriteLine("Game over, Press ENTER to exit.");
            Console.ReadLine();

        }

    }
}
