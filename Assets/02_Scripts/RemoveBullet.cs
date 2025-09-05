using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "BULLET")
        //if (collision.gameObject.tag.Equals("BULLET")) // 똑같은데 Equals가 GC덜 먹음
        if (collision.gameObject.CompareTag("BULLET"))
        {
            Destroy(collision.gameObject);
        }
    }
}
