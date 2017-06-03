using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Monster
{
    public int HP;
    public int Attack, Defense;
    public bool isDead;
    public int stunTurns = 2;
    public int Level;
    Game G;
    private Random r = new Random();

    public Monster(int hp, int ad, int def, int level, ref Game g)
    {
        HP = hp; Attack = ad; Defense = def; Level = level;
        G = g;
    }

    private enum Buildings
    {
        Rada, Farma, Kamieniolom, Zrodlo, Tartak
    }


    public void TakeDamage(int dmg)
    {
         HP -= (dmg / Defense) + 1;

        if (HP > 0) isDead = true;
        else isDead = false;
    }

    void Combat()
    {
        if (isDead) return;
        if (stunTurns > 0)
        {
            stunTurns--;
            return;
        }

        int target = r.Next(0, 5);
        switch(target)
        {
            case 0:
                if (G.RadaOsady != 1) G.RadaOsady--;
                break;
            case 1:
                if (G.Farma != 1) G.Farma--;
                break;
            case 2:
                if (G.Kamieniolom != 1) G.Kamieniolom--;
                break;
            case 3:
                if (G.ZrodloWody != 1) G.ZrodloWody--;
                break;
            case 4:
                if (G.Tartak != 1) G.Tartak--;
                break;
        }
    }
}

