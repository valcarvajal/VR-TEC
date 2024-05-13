using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour
{

    public AudioSource aSource;
    public AudioClip sound;
    public float vol = 1;

    private void OnTriggerEnter(Collider other) {
        AudioSource.PlayClipAtPoint(sound,gameObject.transform.position);
        Destroy(gameObject);

    }

}