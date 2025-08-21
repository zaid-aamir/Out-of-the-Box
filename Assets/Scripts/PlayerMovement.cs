using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Initializing speed variable
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Create a Vector2 using user input
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);

        //Move player using new vector2
        transform.Translate(moveDirection * speed * Time.deltaTime);

        // Add player borders
        float x = transform.position.x;
        float y = transform.position.y;

        x = System.Math.Min(11f, System.Math.Max(-11f, x));
        y = System.Math.Min(4.5f, System.Math.Max(-4.5f, y));

        transform.position = new Vector2(x, y);
    }

    //Checks for any collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if collision was with something deadly
        if (collision.gameObject.CompareTag("death"))
        {
            //If yes, then load deathscreen.
            SceneManager.LoadScene("DeathScreen");
        }
    }
}
