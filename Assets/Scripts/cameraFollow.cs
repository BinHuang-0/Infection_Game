using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

//    public Transform player;
//    public Vector3 offset;
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
//        if(player != null)
//            transform.position = player.position + offset;
        transform.Translate(moveHorizontal, moveVertical, 0);
    }
}
