using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] private Platform[] _platforms;

    public void OnCollectableSelected(Collectable collectable)
    {
        foreach (Platform platform in _platforms)
        {
            if (platform.IsEmpty) 
            {
                platform.SetCollectable(collectable);
                break;
            }
        }
    }
}
