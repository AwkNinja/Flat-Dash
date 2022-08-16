using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float senstivity;  //for speed rotation
    public Transform playercam;
    float x, rotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    // hide or lock the cursor when game start

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * x * senstivity);         //horizontal motion of mouse
        rotation = Mathf.Clamp(rotation, -90f, 90f);   // restrict to move only between 90 to -90
        playercam.localRotation = Quaternion.Euler(rotation, 0f, 0f);   //quaternion is used for rotation and we rotate only x axis so other axis is 0

    }
}
