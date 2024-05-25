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
                Debug.LogWarning("Ayak say�s� 0 dan k���k olamaz!");
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
        Debug.Log("T�r�: " + specie);
        Debug.Log("Ayak say�s�: " + _footCount);
        if (wing)
        {
            Debug.Log("U�abilir");
        }else { Debug.Log("U�amaz!"); }

        if (gill)
        {
            Debug.Log("Su alt�nda nefes alabilir");
        }
        else { Debug.Log("Su alt�nda nefes alamaz!"); }
        Debug.Log(specie + "'in beslenme periyodu " + feedPitch + " saat arayla ger�ekle�ir.");
    }
}

public class Tiger : Animal
{
    public override void DebugAnimalProperties()
    {
        base.DebugAnimalProperties();
        Debug.Log("Beslenme s�resi do�al ya�am ko�ullar�na ba�l� de�i�kenlik g�sterebilir");
    }
}
