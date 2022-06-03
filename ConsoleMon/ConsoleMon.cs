using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        int health;
        int energy;
        string name;
        List<Skill> skills = new List<Skill>();
        Elements weakness;
        
        internal ConsoleMon()
        {

        }                           
        internal ConsoleMon(ConsoleMon CopyFrom)//argument is tussen de haakjes
        {
            this.health = CopyFrom.health;
            this.energy = CopyFrom.energy;
            this.name = CopyFrom.name;  
            this.weakness = CopyFrom.weakness;

            for (int i = 0; i < CopyFrom.skills.Count; i++)
            {
                this.skills.Add(new Skill(CopyFrom.skills[i]));
            }
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
        public void DepleteEnergy(int amount)
        {
            energy -= amount;
        }
    }
}
