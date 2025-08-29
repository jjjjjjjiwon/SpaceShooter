using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // component cash
    // [SerializeField] - private로 쓰고 싶은데 unity에서는 보고 싶을떄 사용

    const float TIME_INTER = 0.25f;
    const float INPUT_VALUE = 0.1f;
    [SerializeField] Transform tr;
    Animation anim;
    [SerializeField] public float moveSpeed = 20.0f;
    [SerializeField] public float turnSpeed = 100.0f;

    void Start()
    {
        // get component
        //tr = this.gameObject.GetComponent<Transform>();
        //tr = GetComponent("Transform") as Transform;   
        //tr = (Transform)GetComponent(typeof(Transform)); 
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();

        anim.Play("Idle");
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");
        Debug.Log($"h = {h}");
        Debug.Log($"v = {v}");
        // Transform.Position
        //transform.position += new Vector3(0, 0, 1);
        // normalized
        // tr.position += Vector3.forward * 1;
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);
        PlayerAnim(h, v);


        //tr.Translate(Vector3.forward * Time.deltaTime * v * moveSpeed, Space.Self); // forward는 Vector3의 Z값과 같다, 어차피 앞으로 가는

    }


    void PlayerAnim(float h, float v)
    {
        if (v >= INPUT_VALUE)
        {
            anim.CrossFade("RunF", TIME_INTER);
        }
        else if (v <= -INPUT_VALUE)
        {
            anim.CrossFade("RunB", TIME_INTER);
        }
        else if (h >= INPUT_VALUE)
        {
            anim.CrossFade("RunR", TIME_INTER);
        }
        else if (h <= -INPUT_VALUE)
        {
            anim.CrossFade("RunL", TIME_INTER);
        }
        else
        {
            anim.CrossFade("Idle", TIME_INTER);
        }
    }
}
