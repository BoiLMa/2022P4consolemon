using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        int damage;
        int energyCost;
        string name;
        Elements element;

        internal Skill()
        {

        }
        internal Skill(Skill eenskill)
        {
            this.damage = eenskill.damage; 
            this.energyCost = eenskill.energyCost;
            this.name = eenskill.name;
            this.element = eenskill.element;
        }
        public void UseOn(ConsoleMon caster, ConsoleMon target)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
    enum Elements
    {
        Fire,
        Grass,
        Electricity,
        Stone,
        Balls,
        H2O
    }
}
