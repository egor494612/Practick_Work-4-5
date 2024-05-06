using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Move : MonoBehaviour
{
    float Speed = 10;
    Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move_();
        Rotation();
    }
    void Move_()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Speed * Time.deltaTime);
    }
    void Rotation()
    {
        float vertical = Input.GetAxisRaw("X");
        float horizontal = Input.GetAxisRaw("Y");
        Vector3 Camera_ROtate = new Vector3(horizontal, vertical, 0.0f);
        transform.Rotate(Camera_ROtate);

    }
}
