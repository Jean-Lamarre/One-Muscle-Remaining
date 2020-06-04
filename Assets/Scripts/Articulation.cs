using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Articulation : MonoBehaviour
{
    private Joint joint;
    private Muscle muscle;
    private Bone bone1;
    private Bone bone2;

    // Start is called before the first frame update
    void Start()
    {
        joint = this.GetComponentInChildren<Joint>();
        muscle = this.GetComponentInChildren<Muscle>();
        bone1 = this.GetComponentInChildren<Bone>();
        bone2 = this.GetComponentInChildren<Bone>();
    }

    void FixedUpdate()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No gamepad connected.

        if (gamepad.rightTrigger.isPressed)
        {
            muscle.contract();
        }
        else
        {
            muscle.relax();
        }

    }
}
