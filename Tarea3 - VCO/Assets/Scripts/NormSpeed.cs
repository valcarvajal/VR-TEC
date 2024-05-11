using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NormSpeed : MonoBehaviour
{
    public ActionBasedContinuousMoveProvider mimove;
    // Start is called before the first frame update
    public void cambiarVelocidad()
    {
        mimove.moveSpeed = 10;
    }
}
