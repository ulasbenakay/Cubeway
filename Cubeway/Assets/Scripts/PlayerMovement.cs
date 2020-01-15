using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWays = 500f;
    public PlayerMovement movement;
    void FixedUpdate() //fxedupdate jumping için yada oneoff events için iyi değil
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // ForceMode.VelocityChange Momentumu engeller. Hızı anında değiştirir ağırlığı önemsemez
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag== "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
