using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObjectOnTrigger : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject myXRRig;
    public int number;

    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(number);
        Instantiate(Prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}

