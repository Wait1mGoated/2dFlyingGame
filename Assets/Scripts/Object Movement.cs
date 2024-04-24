using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float degrees = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomNumber = Random.Range(0, 2);
        if (randomNumber > 0 && randomNumber <= 1)
        {
            transform.position = transform.position + (Vector3.right * moveSpeed);
            transform.rotation = Quaternion.Euler(Vector3.forward * degrees);
        }
        if (randomNumber > 1 && randomNumber <= 3)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed);
            transform.rotation = Quaternion.Euler(Vector3.back * degrees);
        }
    }
}
