using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    [Tooltip("Level timer in seconds")]
    [SerializeField] float levelTime = 10f;
    // Update is called once per frame
    void Update() {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool isDone = Time.timeSinceLevelLoad > levelTime;

        if (isDone) {
            Debug.Log("Level done!");
        }

    }
}
