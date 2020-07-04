using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {
    [Header("Prefabs")]
    [SerializeField] Attacker attackerPrefab;

    [Header("Spawn Config")]
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 6f;

    bool spawn = true;

    IEnumerator Start() {
        while (spawn) {
            var randomTime = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(randomTime);
            SpawnAttacker();
        };
    }

    private void SpawnAttacker() {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }

    void Update() {

    }
}
