using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.B)) {
            Instantiate (cube);
        }
    }
}
