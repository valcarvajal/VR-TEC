using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{

    public AudioSource aSource;
    public AudioClip sound;
    public float vol = 1;
/*
    private int puntuacion;
    public TextMeshProUGUI pts;
    private int temp;

    void Start()
    {
        pts = GetComponent<TextMeshProUGUI>();
        puntuacion = 0;
        print(puntuacion + "0.1");
        pts.text = puntuacion.ToString();
        print(puntuacion + "0.2");
     }
*/
    private void OnTriggerEnter(Collider other) {
        /*print(temp + "t1");
        puntuacion = temp;
        print(puntuacion + "1");
        puntuacion++;
        print(puntuacion + "2");
        pts.text = puntuacion.ToString();
        print(puntuacion + "3");
        temp = puntuacion;
        print(temp + "t2");
        */
        AudioSource.PlayClipAtPoint(sound,aSource.transform.position);
        Destroy(gameObject);
    }
}

