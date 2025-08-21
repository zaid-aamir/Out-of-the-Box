using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovingLavaBehaviour : MonoBehaviour
{
    private Vector2 moveDirection;

    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4f)
            moveDirection = Vector2.down;
        if (transform.position.y < -4f)
            moveDirection = Vector2.up;

        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
