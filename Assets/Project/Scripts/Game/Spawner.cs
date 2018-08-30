using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [Header("Target")]
    public GameObject prefab;

    [Header("Gameplay")]
    public float interval;
    public float minimumX;
    public float maximumX;
    public float y;

    [Header("Visuals")]
    public Sprite[] sprites;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", interval, interval);
	}
	
	private void Spawn () {
        // Instantiate and position the object.
        GameObject instance = Instantiate (prefab);
        instance.transform.position = new Vector2 (
            Random.Range(minimumX, maximumX),
            y
        );
        instance.transform.SetParent (transform);

        // Set a random sprite.
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer> ().sprite = randomSprite;
	}
}
