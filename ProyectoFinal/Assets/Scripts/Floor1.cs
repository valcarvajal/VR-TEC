using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor1 : MonoBehaviour
{
    public GameObject myXRRig;

    // Start is called before the first frame update
    public void GoToLocation()
    {
        myXRRig.transform.position = new Vector3(0,0,0);
    }

}
