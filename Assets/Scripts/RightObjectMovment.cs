using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class RightObjectMovement : MonoBehaviour
{
    public float objectSpeedr = 0.1F;
    public float degreesPerSecr = 360f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * objectSpeedr);
        transform.position = transform.position + (Vector3.left * objectSpeedr);
        float rotAmount = degreesPerSecr * Time.deltaTime;
        float curRot = transform.localRotation.eulerAngles.z;
        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));

    }
}

