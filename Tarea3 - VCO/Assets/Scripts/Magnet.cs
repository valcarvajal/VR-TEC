using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(Rigidbody))]
public class Magnet : MonoBehaviour
{
    public LayerMask layerObjects = 2;
    public bool forcefix = false;
    public float coefAprox = 1.5f;
    public float forceS = 10;
    public float maxDist = 50;

    float distObject = 0;
    float distSQRT = 0;
    float distSQRT_force = 0;

    private void Awake() {
        gameObject.layer = 1;   // 1= layer Transparent FX
    }

    private void FixedUpdate() {
        Collider[] objectRayScope = Physics.OverlapSphere(transform.position, 50, layerObjects);
        foreach (Collider targetCollider in objectRayScope) {
            Transform targetS = targetCollider.transform;
            Rigidbody rbTemp = targetS.GetComponent <Rigidbody> ();
            if (rbTemp) {
                Vector3 dirObject = (transform.position - targetS.position).normalized;
                if (forcefix) {
                    distSQRT = (coefAprox * coefAprox);
                } else {
                    distObject = Vector3.Distance(transform.position, targetS.position);
                    distSQRT = Mathf.Pow(distObject, coefAprox);
                }
                distSQRT_force = (forceS / distSQRT) * 100.0f;
                distSQRT_force = Mathf.Clamp(distSQRT_force, 0.01f, 10000000.0f);

                rbTemp.AddForce(dirObject * distSQRT_force);

                Debug.DrawLine (transform.position, targetS.position, Color.green);
            }
        }
    }
}
