using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Christopher Green)
 * (EnemyManager.cs)
 * (Assignment 1)
 * (This code is the driver for the entire program.)
 */

public class EnemyManager : MonoBehaviour
{
    public Enemy troll;
    public Enemy goblin;
    public Enemy spider;

    public List<Enemy> enemyList = new List<Enemy>();
    public List<ICanStab> canStabList = new List<ICanStab>();
    public List<ICanPunch> canPunchList = new List<ICanPunch>();
    public List<ICanMakeWeb> canMakeWeb = new List<ICanMakeWeb>();


    // Start is called before the first frame update
    void Start()
    {
        //troll = new Troll();
        //goblin = new Goblin();

        //troll.Eat("Human Flesh");
        //goblin.Eat("Apple");

        enemyList.Add(new Troll());
        enemyList.Add(new Goblin());
        enemyList.Add(new Troll());
        enemyList.Add(new Goblin());
        enemyList.Add(new Spider());
        enemyList.Add(new Spider());

        canStabList.Add(new Troll());
        canStabList.Add(new Goblin());
        canStabList.Add(new Troll());
        canStabList.Add(new Goblin());

        canPunchList.Add(new Troll());
        canPunchList.Add(new Goblin());
        canPunchList.Add(new Troll());
        canPunchList.Add(new Goblin());

        canMakeWeb.Add(new Spider());




        // This works too
        //enemyList[0].Eat("Witcher");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy enemy in enemyList)
            {
                enemy.Eat("Apple");
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach(ICanPunch canPunch in canPunchList)
            {
                canPunch.Punch();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach(ICanMakeWeb canMakeWeb in canMakeWeb)
            {
                canMakeWeb.MakeWeb();
            }
        }
    }
}
