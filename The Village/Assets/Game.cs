using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Timers;
using UnityEngine;

public class Game
{
    public static int Drewno, Kamien, Zloto, Woda, Jedzenie, Tartak, Kamieniolom, RadaOsady, ZrodloWody, Farma, Level, Atak, Obrona, PunktyMagii, OdpornoscNaMagie;

    private static System.Timers.Timer woodIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer stoneIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer goldIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer waterIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer foodIncome = new System.Timers.Timer(10000);


    private static void raiseBuilding(int building)
    {
        building += 1;
    }

    private static void woodCallback(object o, ElapsedEventArgs e)
    {
        Drewno += Tartak;
    }
    private static void stoneCallback(object o, ElapsedEventArgs e)
    {
        Kamien += Kamieniolom;
    }

    private static void goldCallback(object o, ElapsedEventArgs e)
    {
        Zloto += RadaOsady;
    }

    private static void waterCallback(object o, ElapsedEventArgs e)
    {
        Woda += ZrodloWody;
    }

    private static void foodCallback(object o, ElapsedEventArgs e)
    {
        Jedzenie += Farma;
    }

	public void Start(int wood = 5, int stone = 5, int money = 500, int water = 100, int food = 100, int tartak = 1,
                      int kamieniolom = 1, int radaosady = 1, int zrodlo = 1, int farma = 1, int level = 1,
                      int attack = 1, int defense = 1, int mp = 1, int mr = 1)
    {
        Kamien = stone; Zloto = money; Woda = water; Jedzenie = food; Tartak = tartak; Kamieniolom = kamieniolom; RadaOsady = radaosady;
        ZrodloWody = zrodlo; Farma = farma; Level = level; Atak = attack; Obrona = defense; PunktyMagii = mp; OdpornoscNaMagie = mr; Drewno = wood;
    }
    
    void Income()
    {
        woodIncome.Elapsed += new ElapsedEventHandler(woodCallback);
        woodIncome.Enabled = true;

        stoneIncome.Elapsed += new ElapsedEventHandler(stoneCallback);
        stoneIncome.Enabled = true;

        goldIncome.Elapsed += new ElapsedEventHandler(goldCallback);
        goldIncome.Enabled = true;

        waterIncome.Elapsed += new ElapsedEventHandler(waterCallback);
        waterIncome.Enabled = true;

        foodIncome.Elapsed += new ElapsedEventHandler(foodCallback);
        foodIncome.Enabled = true;
    }

    public void Load(int wood, int stone, int money, int water, int food, int tartak,
                            int kamieniolom, int radaosady, int zrodlo, int farma, int level,
                            int attack, int defense, int mp, int mr)
    {
        this.Start(wood, stone, money, water, food, tartak, kamieniolom, radaosady, zrodlo, farma, level, attack, defense, mp, mr);
    }
}
