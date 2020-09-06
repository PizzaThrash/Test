using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference for Rigidbody component called "rb"
    public Rigidbody rb;

    // Movement variables ( "f" after the number means we are dealing with float)
    public float forwardForce = 2000f; 
    public float sidewaysForce = 500f;

    // Start is called before the first frame update "void Start()"


    // Update is called once per frame "void Update()"


    // FixedUpdate is used to mess with physics
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   // Add a force of 2000(def) on the Z-axis

        if( Input.GetKey ("d") )
        {
            // Only executed if condition is met
            rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if( Input.GetKey ("a") )
        {
            // Only executed if condition is met
            rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
