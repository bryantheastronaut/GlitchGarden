using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {
    
    [SerializeField] [Range(0, 5f)] float walkSpeed = 1.5f;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // Vector2.anyDirection!
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }
}
