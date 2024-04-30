using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed = 5;
    public bool ShoeAlive = true;
    void Start()
    {
        if (BuyButtons.instance.Gear1) 
        {
            playerSpeed = 7;
        }
        else if (BuyButtons.instance.Gear2)
        {
            playerSpeed = 10;
        }
        else if (BuyButtons.instance.Gear3)
        {
            playerSpeed = 15;
        }
    }


    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 10f), Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {

                transform.position += Vector3.left * playerSpeed * Time.deltaTime;
      
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * playerSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -playerSpeed * Time.deltaTime;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         ShoeAlive = false;
    }

}
