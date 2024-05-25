using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collectable : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    public float JumpForce => _jumpForce;
    private Collider _collider;
    private Rigidbody _rb;
    private PlatformManager _platformManager;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        _rb = GetComponent<Rigidbody>();
        _platformManager = FindObjectOfType<PlatformManager>();
    }

    private void OnMouseDown()
    {
        _platformManager.OnCollectableSelected(this);
    }

    public void OnReachedPlatform()
    {
        _rb.isKinematic = true;
        _collider.enabled = false;
    }
}
