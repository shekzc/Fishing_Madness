using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boatmove : MonoBehaviour
{
    public float moveSpedd = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    
    void Update()
    {
        //Movement of boat
        //transform.Translate(Input.GetAxis("Horizontall") * 15f * Time.deltaTime, 0f, 0f);
        movement.x = Input.GetAxisRaw("Horizontal");
       SoundManager.instance.Boat(true);

        // max_X = 25;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpedd * Time.fixedDeltaTime);
        
        SoundManager.instance.Boat(true);
    }

}
