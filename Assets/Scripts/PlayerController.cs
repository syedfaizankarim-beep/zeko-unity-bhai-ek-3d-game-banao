using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Joystick movementJoystick; // Drag Joystick script here
    
    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        GameManager.instance.UpdateScore(count);
    }

    void FixedUpdate()
    {
        // Get input from Joystick
        float moveHorizontal = movementJoystick.Horizontal;
        float moveVertical = movementJoystick.Vertical;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            GameManager.instance.UpdateScore(count);
        }
    }
}
