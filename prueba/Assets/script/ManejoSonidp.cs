using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejoSonidp : MonoBehaviour
{
    public AudioSource musica;
    //[SerializeField] AudioSource musica2;
    

    public void IniciarMusica(){
        //Script para darle play a la musica cuando yo lo necesito
        musica.Play();

    }
    public void DetenerAudio(){
        musica.Stop();
    }    
}
