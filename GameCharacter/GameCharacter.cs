namespace GameCharacter
{
    public class GameCharacter
    {
        //Properties
        public string Name { get; set; }
        public string CharacterType { get; set; }
        public string WeaponOfChoice { get; set; }
        public int Health { get; set; }
        public int AttackPoints { get; set; }

        //Constructor
        public GameCharacter(string name, string characterType, string weaponOfChoice, int health, int attackPoints)
        {
            Name = name;
            CharacterType = characterType;
            WeaponOfChoice = weaponOfChoice;
            Health = health;
            AttackPoints = attackPoints;
        }


        //Exercise 4:
        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        //Challenge:
        public GameCharacter(string name, string weaponOfChoice)
        {
            Name = name;
            WeaponOfChoice = weaponOfChoice;
        }


        //Methods
        public string Attack()
        {
            return $"{Name} attacks with a {WeaponOfChoice}";
        }



        public string GetHealthValue()
        {
            return $"{Name} currently has {Health} health points";
        }
    }
}
