using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;
    public float handPower;

    bool inHands = false;
    Collider ballCollider;
    Rigidbody ballRBody;
    Camera cam;

    private void Start()
    {
        ballCollider = ball.GetComponent<SphereCollider>();
        ballRBody = ball.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    private void Update()
    {
        if (Input.GetKey("f") && !inHands)
        {
            ballCollider.isTrigger = true;
            ballRBody.useGravity = false;
            ballRBody.velocity = Vector3.zero;
            this.GetComponent<PlayerGrab>().enabled = true;
            ball.transform.SetParent(myHand.transform);
            ball.transform.localPosition = new Vector3(0f, -0.83f, 0f);
            inHands = true;
        }
        else if (Input.GetKey("c") && inHands)
        {
            ballCollider.isTrigger = false;
            ballRBody.useGravity = true;
            this.GetComponent<PlayerGrab>().enabled = false;
            ball.transform.SetParent(null);
            ballRBody.velocity = cam.transform.rotation * Vector3.forward * handPower;
            inHands = false;
        }
    }
}
