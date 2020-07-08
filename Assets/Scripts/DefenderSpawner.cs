using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    Defender currentDefender;
    // Start is called before the first frame update
    void Start() {

    }

    private void OnMouseDown() {
        SpawnDefender(GetSquareClicked());

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

    public void SetCurrentDefender(Defender currentDefender) {
        this.currentDefender = currentDefender;
    }
}
