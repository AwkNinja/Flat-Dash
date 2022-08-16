using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float x;
    float speed = 5.0f;

    void Update()
    {
        //Player is walking with constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Player left movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //Player right movement
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        // increase the speed of player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("IncreaseSpeed");
        }
        if (transform.position.y < -5f)
        {
            FindObjectOfType<GameManager>().GameOver();     //game over if the vertical height goes below -5
        }
    }
    IEnumerator IncreaseSpeed()
    {
        speed = speed + 5f;
        yield return new WaitForSeconds(1f);
        speed = speed - 5f;
    }
}
