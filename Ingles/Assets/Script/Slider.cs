using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    [SerializeField] Slider SliderColor;
    [SerializeField] Slider SliderColor2;
    [SerializeField] Slider SliderColor3;
    Material colorMaterial;
    void Start()
    {
        colorMaterial = GetComponent <MeshRenderer>().material;   
    }

    void Update()
    {
        colorMaterial.color = new Color(SliderColor.value, SliderColor2.value, SliderColor3.value);
    }
}
