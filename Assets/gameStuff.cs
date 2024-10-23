using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStuff : MonoBehaviour
{
    public bool left;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d") && left == true)
        {
            left = false;
        }
        if (Input.GetKeyDown("left") && left == false)
        {
            left = true;
        }
    }
}
