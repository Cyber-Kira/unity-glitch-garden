﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] float baseHealth = 3;
    [SerializeField] int damage = 1;
    float health;
    Text healthText;

    void Start()
    {
        health = baseHealth - PlayerPrefsController.GetDifficulty();
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
        healthText.text = health.ToString();
    }

    public void Hit()
    {
        health = health - damage;
        UpdateDisplay();
    }
}
