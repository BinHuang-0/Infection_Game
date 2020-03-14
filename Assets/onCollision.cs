using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    public GameObject Enemy;

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Player") {
            FindObjectOfType<gameManager>().EndGame();
        }
        else if(collision.gameObject.tag == "Uninfected") {
            Vector3 position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Enemy, position, Quaternion.identity);
        }
    }
}
