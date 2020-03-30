using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trainingDummy;
    int x;
    int z;
    int front;
    int length;

    void Start()
    {
        x = 0;
        z = 0;
        front = 0;
        length = 120;
        length = length * 10;

        for (int i = 0; i < length; i++)
        {
            if (i % 120 == 0)
            {
                z = 0;
                front += 50;
            }

            x += 5;

            if (i % 8 == 0)
            {
                z += 5;
                x = front;
            }

            GameObject tempObject = GameObject.Instantiate(trainingDummy);
            tempObject.transform.position = new Vector3(x, 0, z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
