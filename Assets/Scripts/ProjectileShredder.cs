using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShredder : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<Projectile>()) {
            Destroy(collision.gameObject);
        }
    }
}
