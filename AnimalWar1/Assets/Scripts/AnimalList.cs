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
    }

    public static void ResetAnimals()
    {
        foreach (var a in Animals)
        {
            //a.Reset();
        }
    }
}