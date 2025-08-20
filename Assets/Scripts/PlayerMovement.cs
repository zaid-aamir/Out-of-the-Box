using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
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

        //Add player borders
        if (transform.position.y > 4.5)
            transform.position = new Vector2(transform.position.x, 4.5f);
        if (transform.position.y < -4.5)
            transform.position = new Vector2(transform.position.x, -4.5f);
        if (transform.position.x > 11.5)
            transform.position = new Vector2(11.5f, transform.position.y);
        if (transform.position.x < -11.5)
            transform.position = new Vector2(-11.5f, transform.position.y);
    }
}
