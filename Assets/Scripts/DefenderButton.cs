using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour {
    [SerializeField] Defender defenderPrefab;

    

    private void OnMouseDown() {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton btn in buttons) {
            btn.GetComponent<SpriteRenderer>().color = new Color32(60, 60, 60, 255);
        }

        var sprite = GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetCurrentDefender(defenderPrefab);
    }
}
