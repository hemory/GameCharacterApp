using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
    public class Potions
    {
        public static int IncreaseHealthBy10(int currentHealth)
        {
            return currentHealth + 10;
        }

        public static int DecreaseHealthBy10(int currentHealth)
        {
            return currentHealth - 10;
        }


    }
}
