using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject evilbaby;
    public GameObject jGreen;
    public GameObject mBridges;
    public GameObject rock;
    public GameObject boots;
    public GameObject FirstRoundPick;
    public float objectspawnRate = 7;
    public float timer = 0;
    GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectspawnRate *= .999999f;
        if (timer < objectspawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            float randomNumber = Random.Range(0, 7);
            if (randomNumber > 0 && randomNumber <= 1)
            {
                temp = evilbaby;
            }
            if (randomNumber > 1 && randomNumber <= 2)
            {
                temp = jGreen;
            }
            if (randomNumber > 2 && randomNumber <= 3)
            {
                temp = mBridges;
            }
            if (randomNumber > 3 && randomNumber <= 4)
            {
                temp = rock;
            }
            if (randomNumber > 5 && randomNumber <= 6)
            {
                temp = boots;
            }
            if (randomNumber >= 6)
            {
                temp = FirstRoundPick;
            }
            Instantiate(temp, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
