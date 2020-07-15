using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour {
    Attacker attacker;
    Animator anim;
    private void Start() {
        attacker = GetComponent<Attacker>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject target = collision.gameObject;
        bool isDefender = target.GetComponent<Defender>();
        if (!isDefender) return;

        if(target.GetComponent<Tombstone>()) {
            anim.SetTrigger("JumpTrigger");
        } else {
            attacker.Attack(target);
        }
    }
}
