using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float spinForce;

    private void Update()
    {
        transform.Rotate(0, spinForce * Time.deltaTime, 0);
    }

    public void ChangeSpin()
    {
        spinForce = -spinForce;
    }
}
