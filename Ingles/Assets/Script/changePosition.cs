using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePosition : MonoBehaviour
{
    public GameObject myXRRig;

    public void GoToLocation(Collider other)
    {
        myXRRig.transform.position = new Vector3(0,0,0);
    }

}
