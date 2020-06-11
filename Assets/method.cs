using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class method : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            MethodOn();
        }
    }
    void MethodOn()
    {
        Debug.Log("Method_On");
    }
}
