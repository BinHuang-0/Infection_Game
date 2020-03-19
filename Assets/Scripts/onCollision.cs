using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    public GameObject Enemy;

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Infected") {
            Vector3 position = this.transform.position;
            Destroy(this.gameObject);
            Instantiate(Enemy, position, Quaternion.identity);
            if(GameObject.FindGameObjectsWithTag("Uninfected").Length == 1) {
                FindObjectOfType<gameManager>().EndGame();
            }
        }
        else if(collision.gameObject.tag == "Coin") {
            FindObjectOfType<gameManager>().addScore();
            Destroy(collision.gameObject);
        }
    }
}
