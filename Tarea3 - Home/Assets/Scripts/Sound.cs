using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource aSource;
    public AudioClip sound;

    public void SoundButton () {
        aSource.clip = sound;
        aSource.enabled = false;
        aSource.enabled = true;
    }
}
