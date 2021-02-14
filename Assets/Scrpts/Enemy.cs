using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        AddNonTriggerCollider();
    }

    private void AddNonTriggerCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
