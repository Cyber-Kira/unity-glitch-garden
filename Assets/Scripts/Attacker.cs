using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] int health = 200;
    [SerializeField] float currentSpeed = 1f;


    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Projectile projectile = other.gameObject.GetComponent<Projectile>();
        health = health - projectile.getDamage();
        projectile.Hit();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
