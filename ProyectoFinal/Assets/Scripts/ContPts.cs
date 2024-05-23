using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContPts : MonoBehaviour
{
    private int puntuacion;
    public TMP_Text pts;


    void Start()
    {
        puntuacion = 0;
        print(puntuacion);
        pts.text = "Puntuación = " + puntuacion.ToString();
        print(puntuacion);
    }

    void OnTriggerEnter(Collider other)
    {
        print(puntuacion);
        puntuacion = puntuacion + 1;
        pts.text = "Puntuación = " + puntuacion.ToString();
        print(puntuacion);
    }
}

