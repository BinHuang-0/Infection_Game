using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed;
    GameObject[] uninfected;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        uninfected = GameObject.FindGameObjectsWithTag("Uninfected");
        enemyMove(findClosestUninfected());
    }

    public void enemyMove(Transform player) {
        transform.LookAt(player);

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public Transform findClosestUninfected() {
        float distanceToclosestUninfected = Mathf.Infinity;
        GameObject closestUninfected = null;

        foreach(GameObject u in uninfected) {
            float distanceToUninfected = (u.transform.position - this.transform.position).sqrMagnitude;
            if(distanceToUninfected < distanceToclosestUninfected) {
                distanceToclosestUninfected = distanceToUninfected;
                closestUninfected = u;
            }
        }

        return closestUninfected.transform;
    }
}
