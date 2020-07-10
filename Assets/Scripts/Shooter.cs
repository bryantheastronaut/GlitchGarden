using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] GameObject gun;

    AttackerSpawner myLaneSpawner;
    Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
        SetLaneSpawner();
    }

    private void Update() {
        if (IsAttackerInLane()) {
            anim.SetBool("shouldAttack", true);
        } else {
            // TODO change animation state to idle
            anim.SetBool("shouldAttack", false);
        }
    }

    public void Fire() {
        Instantiate(projectilePrefab, gun.transform.position, Quaternion.identity);
    }

    private void SetLaneSpawner() {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawners) {
            bool isCloseEnough = Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon;
            if (isCloseEnough) myLaneSpawner = spawner;
        }
    }

    private bool IsAttackerInLane() {
        return myLaneSpawner && myLaneSpawner.transform.childCount > 0;
    }

}
