using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejoCubitos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubito;

    public void InstanciarCubos(){
        //Instancia cubos de mi prefab
        Instantiate(PrefabCubito);
    }
    public void InstanciarCubosQueSuenen(){
        Instantiate(PrefabCubito);
    }
}
