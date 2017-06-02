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

class Hero
{
    /// <summary>
    /// Stun - enemy can't move 2 turns
    /// Charm - Hero use his ability to charm opponent and deal double damage
    /// DoubleStraigtAngle - special triangle falls of the sky that deal triple phisical damage
    /// Espionage - Embarasses your opponent, 20% probability of running out of the battle
    /// </summary>
    private enum Spells
    {
        Stun, Charm, DoubleStraightAngle, Espionage
    }

    private int attack, defense, magicpower, magicresist, experience;
    public string Name;
    private Spells spell;

    public Hero(HeroBase hb)
    {
        if(hb == HeroBase.Darius)
        {
            attack = 3;
            defense = 2;
            magicpower = 1;
            magicresist = 2;
            experience = 0;
            spell = Spells.Stun;
            Name = "Darius";
        }
        else if(hb == HeroBase.Wojtimus)
        {
            attack = 4;
            defense = 1;
            magicpower = 2;
            magicresist = 1;
            experience = 0;
            spell = Spells.Charm;
            Name = "Wojtimus";
        }
        else if(hb == HeroBase.Zuberus)
        {
            attack = 1;
            defense = 1;
            magicpower = 3;
            magicresist = 3;
            spell = Spells.DoubleStraightAngle;
            Name = "Zuberus";   
        }
        else //Snailus
        {
            attack = 2;
            defense = 2;
            magicpower = 2;
            magicresist = 2;
            spell = Spells.Espionage;
            Name = "Snailus";
        }
    }

    public void LevelUp(string ability)
    {
        if (ability == "attack") attack++;
        else if (ability == "defense") defense++;
        else if (ability == "magicpower") magicpower++;
        else magicresist++;

        if (Name == "Darius") attack++;
    }
}
