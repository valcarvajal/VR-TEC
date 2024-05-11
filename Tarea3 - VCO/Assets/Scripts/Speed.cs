using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Speed : MonoBehaviour
{
    public ContinuousMoveProviderBase mimove;
    public void cambiarVelocidad()
    {
        Debug.Log("cambiando velocidad" +  mimove.moveSpeed);
        mimove.moveSpeed = 80f;
         mimove.moveSpeed = 800f;

        
    }
}

