using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Timers;
using UnityEngine;

public struct Costs
{
   public int woodCost, stoneCost, goldCost, waterCost, foodCost;
}

public class Game
{
    public int Drewno, Kamien, Zloto, Woda, Jedzenie, Tartak, Kamieniolom, RadaOsady, ZrodloWody, Farma, Level, Atak, Obrona, PunktyMagii, OdpornoscNaMagie;
    public static string HeroName;
    private static System.Timers.Timer woodIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer stoneIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer goldIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer waterIncome = new System.Timers.Timer(10000);
    private static System.Timers.Timer foodIncome = new System.Timers.Timer(10000);


    public void UpgradeTartak  (int level)
    {
        Costs c = new Costs();
        c.woodCost = 3 * level;
        c.stoneCost = 5 * level;
        c.goldCost = 15 * level;
        c.waterCost = 8 * level;
        c.foodCost = 7 * level;

        if(!upgradeBuilding(ref Tartak, c)) throw new System.Exception("Not enough materials!");
    }
    public void UpgradeKamien  (int level)
    {
        Costs c = new Costs();
        c.woodCost = 5 * level;
        c.stoneCost = 3 * level;
        c.goldCost = 12 * level;
        c.waterCost = 10 * level;
        c.foodCost = 8 * level;

        if(!upgradeBuilding(ref Kamieniolom, c)) throw new System.Exception("Not enough materials!");
    }
    public void UpgradeGold    (int level)
    {
        Costs c = new Costs();
        c.woodCost = 6 * level;
        c.stoneCost = 6 * level;
        c.goldCost = 4 * level;
        c.waterCost = 9 * level;
        c.foodCost = 9 * level;

        if(!upgradeBuilding(ref RadaOsady, c)) throw new System.Exception("Not enough materials!");
    }
    public void UpgradeWoda    (int level)
    {
        Costs c = new Costs();
        c.woodCost = 4 * level;
        c.stoneCost = 4 * level;
        c.goldCost = 15 * level;
        c.waterCost = 2 * level;
        c.foodCost = 6 * level;

        if(!upgradeBuilding(ref ZrodloWody, c)) throw new System.Exception("Not enough materials!");
    }
    public void UpgradeJedzenie(int level)
    {
        Costs c = new Costs();
        c.woodCost = 5 * level;
        c.stoneCost = 5 * level;
        c.goldCost = 4 * level;
        c.waterCost = 7 * level;
        c.foodCost = 3 * level;

        if(!upgradeBuilding(ref Farma, c)) throw new System.Exception("Not enough materials!");
    }

    private bool upgradeBuilding(ref int building, Costs costs)
    {
        if (costs.woodCost <= Drewno &&  costs.stoneCost <= Kamien && costs.goldCost <= Zloto && costs.waterCost <= Woda && costs.foodCost <= Jedzenie)
        {
            Drewno -= costs.woodCost; Kamien -= costs.stoneCost; Zloto -= costs.goldCost; Woda -= costs.waterCost; Jedzenie -= costs.foodCost;
            raiseBuilding(ref building);
            return true;
        }
        else return false;
    }
    private static void raiseBuilding(ref int building)
    {
        building += 1;
    }

    private void woodCallback(object o, ElapsedEventArgs e)
    {
        Drewno += Tartak;
    }
    private void stoneCallback(object o, ElapsedEventArgs e)
    {
        Kamien += Kamieniolom;
    }
    private void goldCallback(object o, ElapsedEventArgs e)
    {
        Zloto += RadaOsady;
    }
    private void waterCallback(object o, ElapsedEventArgs e)
    {
        Woda += ZrodloWody;
    }
    private void foodCallback(object o, ElapsedEventArgs e)
    {
        Jedzenie += Farma;
    }

	public void Start(Hero h, int wood = 5, int stone = 5, int money = 500, int water = 100, int food = 100, int tartak = 1,
                      int kamieniolom = 1, int radaosady = 1, int zrodlo = 1, int farma = 1, int level = 1)
    {
        Kamien = stone; Zloto = money; Woda = water; Jedzenie = food; Tartak = tartak; Kamieniolom = kamieniolom; RadaOsady = radaosady;
        ZrodloWody = zrodlo; Farma = farma; Level = level; Atak = h.Attack; Obrona = h.Defense; PunktyMagii = h.MagicPower;
        OdpornoscNaMagie = h.MagicResist; Drewno = wood;
    } 
    private void Income()
    {
        woodIncome.Elapsed += new ElapsedEventHandler(this.woodCallback);
        woodIncome.Enabled = true;

        stoneIncome.Elapsed += new ElapsedEventHandler(this.stoneCallback);
        stoneIncome.Enabled = true;

        goldIncome.Elapsed += new ElapsedEventHandler(this.goldCallback);
        goldIncome.Enabled = true;

        waterIncome.Elapsed += new ElapsedEventHandler(this.waterCallback);
        waterIncome.Enabled = true;

        foodIncome.Elapsed += new ElapsedEventHandler(this.foodCallback);
        foodIncome.Enabled = true;
    }
    public void Load(Hero h, int wood, int stone, int money, int water, int food,
                     int tartak, int kamieniolom, int radaosady, int zrodlo, int farma)
    {

        Start(h, wood, stone, money, water, food, tartak, kamieniolom, radaosady, zrodlo, farma);
    }
}
