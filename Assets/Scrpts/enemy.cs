using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int ScorePerHit = 10;
    [SerializeField] int hits = 20;
    scoreBoard Scoreboard;

    void Start()
    {
        addNonTriggerBoxCollider();
        Scoreboard = FindObjectOfType<scoreBoard>();
    }

    private void addNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHits();
        if (hits < 1)
        {
            KillEnemy();
        }

    }

    private void ProcessHits()
    {
        Scoreboard.ScoreHit(ScorePerHit);
        hits--;
    }

    private void KillEnemy()
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
