using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {
    [SerializeField] int playerHP = 3;
    Text hpText;

    private void Start() {
        hpText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText() {
        if (hpText) {
            hpText.text = playerHP.ToString() + " HP";
        }
    }

    public void LoseHP() {
        playerHP = Mathf.Max(0, playerHP - 1);
        UpdateText();
        if (playerHP <= 0) {
            StartCoroutine(DelayGameOver());
        }
    }

    IEnumerator DelayGameOver() {
        yield return new WaitForSeconds(2);
        FindObjectOfType<LevelLoader>().LoadLoseScene();
    }
}
