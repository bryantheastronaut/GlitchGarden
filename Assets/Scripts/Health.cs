using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVfx;

    public void InflictDamage(float amount) {
        health -= amount;
        ReactToDamage();
    }

    private void ReactToDamage() {
        if (health <= 0) {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX() {
        if (!deathVfx) return;
        var effect = Instantiate(deathVfx, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
    }
}
