using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColor : MonoBehaviour
{
    public GameObject Sphere;

    public void RandomColorSphere()
    {
       Sphere.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
