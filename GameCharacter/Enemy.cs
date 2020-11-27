using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
   public class Enemy
    {
        public int AttackPoints { get; set; }
        public int Health { get; set; }

        public Enemy(int attackPoints, int health)
        {
            AttackPoints = attackPoints;
            Health = health;
        }

        public int ReduceCharacterHealth(GameCharacter gameCharacter)
        {
            return gameCharacter.Health - AttackPoints;
        }

        public int ReduceEnemiesHealth(GameCharacter gameCharacter)
        {
            
            return Health - gameCharacter.AttackPoints;
        }

        public string GetHealthValue()
        {
            return $"Enemy currently has {Health} health points";
        }


    }
}
