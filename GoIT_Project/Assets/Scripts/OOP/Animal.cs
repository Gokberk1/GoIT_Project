using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public string specie;
    private int _footCount;
    public int FootCount 
    { 
        get { return _footCount; }
        set 
        { 
            if(value < 0)
            {
                Debug.LogWarning("Ayak sayýsý 0 dan küçük olamaz!");
                return;
            }
            _footCount = value;
        } 
    }
    public int feedPitch;
    public bool wing;
    public bool gill;
    public virtual void DebugAnimalProperties()
    {
        Debug.Log("Türü: " + specie);
        Debug.Log("Ayak sayýsý: " + _footCount);
        if (wing)
        {
            Debug.Log("Uçabilir");
        }else { Debug.Log("Uçamaz!"); }

        if (gill)
        {
            Debug.Log("Su altýnda nefes alabilir");
        }
        else { Debug.Log("Su altýnda nefes alamaz!"); }
        Debug.Log(specie + "'in beslenme periyodu " + feedPitch + " saat arayla gerçekleþir.");
    }
}

public class Tiger : Animal
{
    public override void DebugAnimalProperties()
    {
        base.DebugAnimalProperties();
        Debug.Log("Beslenme süresi doðal yaþam koþullarýna baðlý deðiþkenlik gösterebilir");
    }
}
