using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    Renderer rend;
    Color color;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        color = rend.material.color;     //default color of player
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            StartCoroutine("ChangePlayerColor");

        }
    }

    IEnumerator ChangePlayerColor()
    {
        color.a = 0.5f;        // fade color of player
        //rend.material .color=color;   //set fade value in rendrer
        rend.material.color = Color.red;
        yield return new  WaitForSeconds(1f);
        color.a = 1f;        // return to original color
        rend.material.color = color;
    }
}
