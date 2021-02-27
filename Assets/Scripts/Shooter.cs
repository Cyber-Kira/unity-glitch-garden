﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();    
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot pew pew");
            // TODO change animation state to shooting
        }
        else
        {
            Debug.Log("Sit and wait");
            // TODO change animation state to IDLE
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        return true;
    }
    public void Fire(float damage)
    {
        Instantiate(
            projectile,
            gun.transform.position,
            transform.rotation
        );
    }
}
