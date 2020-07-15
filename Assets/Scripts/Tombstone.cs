using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tombstone : MonoBehaviour {
    private void OnCollisionStay2D(Collision2D collision) {
        Attacker attacker = collision.gameObject.GetComponent<Attacker>();
        if (attacker) {
            // TODO do some animation
        }
        
    }
}
