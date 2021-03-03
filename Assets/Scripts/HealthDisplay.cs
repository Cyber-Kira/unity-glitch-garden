using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] int damage = 5;
    Text healthText;

    void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (health <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadFirstScene();
        }
        healthText.text = health.ToString();
    }

    public void Hit()
    {
        health = health - damage;
        UpdateDisplay();
    }

}
