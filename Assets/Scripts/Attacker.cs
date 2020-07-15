using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {
    GameObject currentTarget;
    float currentSpeed = 1f;
    Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    void Update() {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState() {
        if (currentTarget) { anim.SetBool("isAttacking", true); }
        else { anim.SetBool("isAttacking", false); }
    }

    public void SetMovementSpeed(float speed) {
        currentSpeed = speed;
    }

    public void Attack(GameObject target) {
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage) {
        if (!currentTarget) return;
        Health targetHealth = currentTarget.GetComponent<Health>();
        if (targetHealth) {
            targetHealth.InflictDamage(damage);
        }
    }
}
