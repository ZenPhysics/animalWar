using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class AnimalList
{
    static List<animalController> Animals;

    static AnimalList()
    {
        Animals = new List<animalController>();
    }

    public static void AddAnimal(animalController a)
    {
        Animals.Add(a);
        Debug.Log("ADDED to Aniaml List");
    }

    public static void ResetAnimals()
    {
        Debug.Log("//////////////Reset called");
        foreach (var a in Animals)
        {
            a.MovementPoints = a.TotalPointsPerTurn;
            Debug.Log("//////////////FORLOOP called");
        }
    }

    public static void resetAttacks()
    {
        foreach (var a in Animals)
        {
            a.hasAttacked = false;
        }
    }
}