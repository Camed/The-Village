using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum HeroBase
{
    Darius, Wojtimus, Zuberus, Snailus
    /*
     * Darius passive - additional 1 damage point per level
     * Wojtimus passive - church boss, gains additional money
     * Zuberus passive - best baker, double food gain
     * Snailus passive - tutor - gains 5% more experience
     */
}

public class Hero
{
    /// <summary>
    /// Stun - enemy can't move 2 turns
    /// Charm - Hero use his ability to charm opponent and deal double damage
    /// DoubleStraigtAngle - special triangle falls of the sky that deal triple phisical damage
    /// Espionage - Embarasses your opponent, 20% probability of running out of the battle
    /// </summary>
    public enum Spells
    {
        Stun, Charm, DoubleStraightAngle, Espionage
    }

    public int Attack, Defense, MagicPower, MagicResist, Experience, Level;
    public string Name;
    public Spells spell;

    public Hero() { }
    public Hero(HeroBase hb)
    {
        if(hb == HeroBase.Darius)
        {
            Attack = 3;
            Defense = 2;
            MagicPower = 1;
            MagicResist = 2;
            Experience = 0;
            Level = 1;
            spell = Spells.Stun;
            Name = "Darius";
        }
        else if(hb == HeroBase.Wojtimus)
        {
            Attack = 4;
            Defense = 1;
            MagicPower = 2;
            MagicResist = 1;
            Experience = 0;
            Level = 1;
            spell = Spells.Charm;
            Name = "Wojtimus";
        }
        else if(hb == HeroBase.Zuberus)
        {
            Attack = 1;
            Defense = 1;
            MagicPower = 3;
            MagicResist = 3;
            Level = 1;
            spell = Spells.DoubleStraightAngle;
            Name = "Zuberus";   
        }
        else //Snailus
        {
            Attack = 2;
            Defense = 2;
            MagicPower = 2;
            MagicResist = 2;
            Level = 1;
            spell = Spells.Espionage;
            Name = "Snailus";
        }
    }

    public void LevelUp(string ability)
    {
        if (ability == "attack") Attack++;
        else if (ability == "defense") Defense++;
        else if (ability == "magicpower") MagicPower++;
        else MagicResist++;

        if (Name == "Darius") Attack++;
    }
}
