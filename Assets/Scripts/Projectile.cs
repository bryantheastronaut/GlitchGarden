using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] float speed = 7.5f;
    [SerializeField] float damage = 50f;

    void Update() {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Trigger entered " + collision.name);
        if (collision.CompareTag("Attacker")) {
            var health = collision.GetComponent<Health>();
            var attacker = collision.GetComponent<Attacker>();
            if (health && attacker) {
                health.InflictDamage(damage);
                Destroy(gameObject);
            }

        }
    }
}
