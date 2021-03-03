using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBoundry : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) {
        FindObjectOfType<HealthDisplay>().Hit();
        Destroy(other.gameObject);
    }

}
