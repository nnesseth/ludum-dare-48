using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField] private float speed = 6.0f;
    [SerializeField] private float rotateSpeed = 3.0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        // Rotate around the y axis
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.transform.Translate(move * Time.deltaTime * speed);
    }
}