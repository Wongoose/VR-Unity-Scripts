using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour

{
    public int playerSpeed;

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        else if(Input.GetKey("s"))
        {
            transform.position = transform.position - Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("a"))
        {
            transform.position = transform.position - Camera.main.transform.right * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("d"))
        {
            transform.position = transform.position + Camera.main.transform.right * playerSpeed * Time.deltaTime;
        }
    }
}
