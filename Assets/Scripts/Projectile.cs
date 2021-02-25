using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] int damage = 100;
    float rotationSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.right * Time.deltaTime * speed, Space.Self);
    }

    public void Hit()
    {
        Destroy(gameObject);
    }

    public int getDamage()
    {
        return damage;
    }
}
