using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_break : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
