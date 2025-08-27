using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // component cash
    // [SerializeField] - private로 쓰고 싶은데 unity에서는 보고 싶을떄 사용
    [SerializeField] Transform tr; 
    [SerializeField] public float moveSpeed = 20.0f;

    void Start()
    {
        // get component
        //tr = this.gameObject.GetComponent<Transform>();
        //tr = GetComponent("Transform") as Transform;   
        //tr = (Transform)GetComponent(typeof(Transform)); 
        tr = GetComponent<Transform>();
        moveSpeed = 3.0f;
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
        // tr.position += Vector3.forward * 1;
        tr.Translate(Vector3.forward * Time.deltaTime * v * moveSpeed, Space.Self); // forward는 Vector3의 Z값과 같다, 어차피 앞으로 가는
    }
}
