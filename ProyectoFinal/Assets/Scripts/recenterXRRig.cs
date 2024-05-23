using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recenterXRRig : MonoBehaviour
{
    public GameObject myXRRig;

    // Start is called before the first frame update
    void Start()
    {
        myXRRig.transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
