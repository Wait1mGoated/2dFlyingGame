using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDisappearing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Ground;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > 2)
            Ground.SetActive(false);
    }
}
