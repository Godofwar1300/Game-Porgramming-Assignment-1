using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Christopher Green)
 * (Enemy.cs)
 * (Assignment 1)
 * (This code is responsible for holding the abstract class, as well as, the enemy classes.)
 */


public abstract class Enemy
{

    public abstract void Eat(string foodFav);

}

public class Goblin : Enemy, ICanStab, ICanPunch
{
    public override void Eat(string foodFav)
    {
        Debug.Log("The Goblin eats the " + foodFav);
    }

    public void Punch()
    {
        Debug.Log("The Goblin punches.");
    }

    public void Stab()
    {
        Debug.Log("The Goblin stabs forward.");
    }
}

public class Troll : Enemy, ICanStab, ICanPunch
{
    public override void Eat(string foodFav)
    {
        Debug.Log("The Troll eats the " + foodFav);
    }

    public void Punch()
    {
        Debug.Log("The Troll punches.");
    }

    public void Stab()
    {
        Debug.Log("The Troll stabs forward.");
    }
}

public class Spider : Enemy, ICanMakeWeb
{
    public override void Eat(string foodFav)
    {
        Debug.Log("The Spider eats the " + foodFav);
    }

    public void MakeWeb()
    {
        Debug.Log("The spider spins a web");
    }
}