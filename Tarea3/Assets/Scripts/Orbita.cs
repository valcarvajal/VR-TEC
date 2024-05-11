using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    public float velRot = 50f;

    void Update()
    {
        this.transform.Rotate(new Vector3 (0, velRot, 0) * Time.deltaTime);
    }
}
