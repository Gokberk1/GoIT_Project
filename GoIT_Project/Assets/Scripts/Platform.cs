using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Platform : MonoBehaviour
{
    public bool IsEmpty { get; private set; } = true;
    [SerializeField] private Transform _placeHolder;
    private Collectable _collectable;

    public void SetCollectable(Collectable collectable)
    {
        IsEmpty = false;
        _collectable = collectable;
        collectable.transform.DOJump(_placeHolder.transform.position, collectable.JumpForce, 1, 1)
            .OnComplete(collectable.OnReachedPlatform);
    }

}
