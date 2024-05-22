using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    [SerializeField] private Transform objective;

    private void Update()
    {
        float RadAngle = Mathf.Atan2(objective.position.y - transform.position.y, objective.position.x - transform.position.x);
        float DegAngle = (180/Mathf.PI) * RadAngle - 90;
        transform.rotation = Quaternion.Euler(0, 0, DegAngle);
    }
}
