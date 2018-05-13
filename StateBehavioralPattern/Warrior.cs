using System;
using System.Collections.Generic;
using System.Text;

namespace StateBehavioralPattern
{
    //LDSTA003
    public class Warrior
    {
        private IHealth health = new Normal();  //start as normal health

        public void Battle()
        {
            health.DoBattle(this);  //calls the health to exhibit the behavior
        }

        public void SetHealth(IHealth health)
        {
            this.health = health;
        }

        public void ShowHealth()
        {
            Console.WriteLine("Warrior is now: " + health.GetType().ToString());
        }
    }
}
