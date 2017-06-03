using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using UnityEngine;

public static class Buttons
{

    public static void NewGame()
    {
        //Game g = new Game();
        //System.Random r = new System.Random();
        //Hero h = new Hero((HeroBase)r.Next(0, 5));
        //g.Start(h);
    }

    public static void LoadLastGame()
    {
        //string[] save = File.ReadAllLines(@"./saves/save.txt");

        //int wood = 0, stone = 0, money = 0, water = 0, food = 0, tartak = 0, kamieniolom = 0, radaosady = 0, zrodlo = 0, farma = 0,
        //    lvl = 0, attack = 0, defense = 0, mp = 0, mr = 0;
        //string nazwa = "";

        //int.TryParse(save[0], out wood); int.TryParse(save[1], out stone);
        //int.TryParse(save[2], out money); int.TryParse(save[3], out water);
        //int.TryParse(save[4], out food); int.TryParse(save[5], out tartak);
        //int.TryParse(save[6], out kamieniolom); int.TryParse(save[7], out radaosady);
        //int.TryParse(save[8], out zrodlo); int.TryParse(save[9], out farma);
        //int.TryParse(save[10], out lvl); int.TryParse(save[11], out attack);
        //int.TryParse(save[12], out defense); int.TryParse(save[13], out mp);
        //int.TryParse(save[14], out mr); nazwa = save[15];

        //Hero h = new Hero();
        //h.Attack = attack; h.Defense = defense;
        //h.MagicPower = mp; h.MagicResist = mr;
        //h.Name = nazwa;

        //Game g = new Game();
        //g.Load(h, wood, stone, money, water, food, tartak, kamieniolom, radaosady, zrodlo, farma);
    }

    public static void Exit()
    {
        Environment.Exit(0);
    }

}
