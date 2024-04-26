using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    public bool ShoeAlive = true;
    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x > -10)
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }

        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x < 10)
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         ShoeAlive = false;
    }

}
