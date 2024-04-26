using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class ObjectMovement : MonoBehaviour
{
    public float objectSpeed = 0.01F;
    public float degreesPerSec = 360f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectSpeed *= 1.0001f;
        transform.position = transform.position + (Vector3.down * objectSpeed);
        transform.position = transform.position + (Vector3.right * objectSpeed);
        float rotAmount = degreesPerSec * Time.deltaTime;
        float curRot = transform.localRotation.eulerAngles.z;
        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
      
    }
}
