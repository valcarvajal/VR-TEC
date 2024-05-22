using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatioOnClick : MonoBehaviour
{

    public GameObject model1;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;

    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public AudioSource audioSource;


    public void Start(){
        animator1 = model1.GetComponent<Animator>();
        animator2 = model2.GetComponent<Animator>();
        animator3 = model3.GetComponent<Animator>();
        animator4 = model4.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    
    public void playAnimation(){
        animator1.Play("Sitting Talking");
        animator2.Play("Sitting Talking");
        animator3.Play("Sitting Talking 1");
        animator4.Play("Sitting Talking 1");
        audioSource.Play();
    }


public void stopAnimation(){
    animator1.Play("Idle");
    animator2.Play("Idle");
    animator3.Play("Idle");
    animator4.Play("Idle");
    audioSource.Stop();
}
}
