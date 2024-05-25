using JetBrains.Annotations;
using UnityEngine;

public class OOPExample : MonoBehaviour
{
    Animal _dog;
    Animal _fish;
    Tiger _tiger;

    private void Awake()
    {
        _dog = new Animal();
        _dog.specie = "Golden Retreiver";
        _dog.FootCount = 4;
        _dog.wing = false;
        _dog.gill = false;
        _dog.feedPitch = 4;
        _dog.DebugAnimalProperties();

        _fish = new Animal();
        _fish.specie = "Clownfish";
        _fish.FootCount = 0;
        _fish.wing = false;
        _fish.gill = true;
        _fish.feedPitch = 5;
        _fish.DebugAnimalProperties();

        _tiger = new Tiger();
        _tiger.specie = "Siberian Tiger";
        _tiger.FootCount = 4;
        _tiger.wing = false;
        _tiger.gill = false;
        _tiger.feedPitch = 12;
        _tiger.DebugAnimalProperties();
    }
}
