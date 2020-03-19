using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical);
    }
}
