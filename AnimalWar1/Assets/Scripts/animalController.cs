using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalController : MonoBehaviour
{
    public float MoveSpeed
    {
        get { return MoveSpeed; }
        set { MoveSpeed = value; }
    }
    public float Health
    {
        get { return Health; }
        set { Health = value; }
    }
    public float Attack
    {
        get { return Attack; }
        set { Attack = value; }
    }
    public float Armor
    {
        get { return Armor; }
        set { Armor = value; }
    }
    public bool IsEnemy
    {
        get { return IsEnemy; }
        set { IsEnemy = value; }
    }
    public bool CanSwim
    {
        get { return CanSwim; }
        set { CanSwim = value; }
    }
    public bool CanFly
    {
        get { return CanFly; }
        set { CanFly = value; }
    }
    public bool RangeAttack
    {
        get { return RangeAttack; }
        set { RangeAttack = value; }
    }
    public int ResourceCost
    {
        get { return ResourceCost; }
        set { ResourceCost = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveCharacter()
    {

    }
    private void FightEnemy()
    {

    }
    private void InteractWithTile()
    {

    }
}
