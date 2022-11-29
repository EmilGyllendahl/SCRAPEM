using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 0.0f;
    [SerializeField] private float maxSpeed = 20f;
    [SerializeField] private float rotationSpeed = 50f;
    
    void Update()
    {
        // to move left or right
        if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0)
        {
            transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"),
                Space.World);
        }

        //to move forward or backward
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"),
                Space.World);
        }
        
    }
}
