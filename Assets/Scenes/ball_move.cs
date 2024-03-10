using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{

    public float speed = 3.93f;
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }
}
