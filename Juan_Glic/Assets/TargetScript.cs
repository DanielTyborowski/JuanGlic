﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    public GameObject target;
    int count = 0;

    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <=0f)
        {
            Die();
        }
    }
    
    void Die()
    {
        Destroy(gameObject);
    }

    // 50 times per secound
    void FixedUpdate()
    {
        count++;
        if(count>=100){
            Vector3 pos = new Vector3(Random.Range(5f, -5f),Random.Range(1f, 10f),-30);
            Instantiate(target, pos, Quaternion.Euler(90f, 0f, 0f));
            count = 0;
        }
        
    }
}
