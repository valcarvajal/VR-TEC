using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public GameObject myXRRig;

    public void OnTriggerEnter(Collider other)
    {
        // myXRRig.transform.position = new Vector3(0,0,0);
        SceneManager.LoadScene(0);
        // XRInputSubsystem.TryRecenter();
    }

}