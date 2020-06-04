using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muscle : MonoBehaviour
{
    private float force;

    private float lenght;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        lenght = this.transform.localScale.y;
        force = lenght / 50;
    }

    public void contract()
    {

        if (this.transform.localScale.y > (lenght / 50))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y - force, this.transform.localScale.z);
        }
    }

    public void relax()
    {
        if (this.transform.localScale.y > lenght)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y - force, this.transform.localScale.z);
        }
        else if (this.transform.localScale.y < lenght)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y + force, this.transform.localScale.z);
        }

    }

    public void setForce(float newForce)
    {
        this.force = newForce;
    }

    public float getForce()
    {
        return this.force;
    }
}
