using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private int score;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag.Equals("Player"))
        {
            score += 10;
            FindObjectOfType<GameManager>().IncrementScore(score);
            FindObjectOfType<Sound>().playSound();
            Destroy(gameObject);
        }
    }

}
