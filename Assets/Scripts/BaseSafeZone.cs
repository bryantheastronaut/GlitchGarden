using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSafeZone : MonoBehaviour {
    [SerializeField] int playerHp = 3;

    private void OnTriggerEnter2D(Collider2D collision) {
        FindObjectOfType<PlayerHP>().LoseHP();
        Destroy(collision.gameObject, 2f);
    }
}
