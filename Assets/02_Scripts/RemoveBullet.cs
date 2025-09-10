using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;
    void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "BULLET")
        //if (collision.gameObject.tag.Equals("BULLET")) // 똑같은데 Equals가 GC덜 먹음
        if (collision.gameObject.CompareTag("BULLET"))
        {
            ContactPoint cp = collision.GetContact(0);
            Quaternion rot = Quaternion.LookRotation(-cp.normal);

            GameObject spark = Instantiate(sparkEffect, collision.transform.position, Quaternion.identity);
            Destroy(spark, 0.5f);
            Destroy(collision.gameObject);
        }
    }
}
