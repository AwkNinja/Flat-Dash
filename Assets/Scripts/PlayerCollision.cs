using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement control;      //making a reference for the player movement script

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag.Equals("Obstacle") || collision.collider.tag.Equals("Bullet"))    //check if the object the player collided with has a tag called obstacle
        {
            control.enabled = false;    //disabling the player movement
            FindObjectOfType<GameManager>().GameOver();     //calls the game over function from GameManager
        }
    }
}
