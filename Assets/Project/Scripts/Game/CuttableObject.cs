using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttableObject : MonoBehaviour {

    public bool harmful;
     
	void OnCollisionEnter2D (Collision2D collision) {
        // Identify if the object is being cut.
        if (collision.gameObject.tag == "Cut") {
            Destroy (gameObject);

            if (!harmful) {
                GameObject.Find("ScoreText").transform.GetComponent<ScoreText>().Score += 10;
            } else {
                GameObject.Find("LifeCounter").transform.GetComponent<LifeCounter> ().LoseLife ();
            }
        }
    }
}
