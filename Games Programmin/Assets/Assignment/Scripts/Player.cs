using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController Controller;

    public float speed;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            float targetLookAngel = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg; // calculates the amount needed to rotate  around the y axis
            float angle = Mathf.SmoothDampAngle(transform.rotation.eulerAngles.y, targetLookAngel, ref turnSmoothVelocity, turnSmoothTime); // smooths the turning
            transform.rotation = Quaternion.Euler(0f,targetLookAngel,0f);
            Controller.Move(moveDirection * speed * Time.deltaTime);
        }
    }
}
