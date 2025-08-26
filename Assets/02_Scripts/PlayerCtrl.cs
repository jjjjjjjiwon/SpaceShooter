using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // component cash
    Transform tr;

    void Start()
    {
        // get component
        //tr = this.gameObject.GetComponent<Transform>();
        //tr = GetComponent("Transform") as Transform;   
        //tr = (Transform)GetComponent(typeof(Transform)); 
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log($"h = {h}");
        Debug.Log($"v = {v}");
        // Transform.Position
        //transform.position += new Vector3(0, 0, 1);
        // normalized
        tr.position += Vector3.forward * 1;
    }
}
