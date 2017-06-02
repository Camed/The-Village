using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame
{
    public int Wood = 0, Stone = 0, Money = 0, Water = 0, Food = 0, Tartak = 0, Kamieniolom = 0, RadaOsady = 0, Zrodlo = 0, Farma = 0,
               Level = 1, Attack = 1, Defense = 1, MagicPower = 1, MagicResist = 1;
    public MainGame(int wood, int stone, int money, int water, int food, int tartak,
                    int kamieniolom, int radaosady, int zrodlo, int farma, int level,
                    int attack, int defense, int mp, int mr)
    {
        Wood = wood; Stone = stone; Money = money; Water = water; Food = food; Tartak = tartak; Kamieniolom = kamieniolom; MagicResist = mr;
        RadaOsady = radaosady; Zrodlo = zrodlo; Farma = farma; Level = level; Attack = attack; Defense = defense; MagicPower = mp;
    }
}
