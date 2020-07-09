using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    Defender currentDefender;
    StarDisplay starDisplay;

    private void Start() {
        starDisplay = FindObjectOfType<StarDisplay>();
    }

    private void OnMouseDown() {
        AttemptPlaceDefender(GetSquareClicked());
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos) {
        int newX = Mathf.RoundToInt(rawWorldPos.x);
        int newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);

    }

    private Vector2 GetSquareClicked() {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return SnapToGrid(worldPos);
    }

    private void SpawnDefender(Vector2 spawnPoint) {
        if (currentDefender) {
            Instantiate(currentDefender, spawnPoint, Quaternion.identity);
        }
    }

    private void AttemptPlaceDefender(Vector2 gridPos) {
        var defenderCost = currentDefender.GetStarCost();
        if (starDisplay.CanSpendStars(defenderCost)) {
            starDisplay.SpendStars(defenderCost);
            SpawnDefender(gridPos);
        }
    }

    public void SetCurrentDefender(Defender currentDefender) {
        this.currentDefender = currentDefender;
    }
}
