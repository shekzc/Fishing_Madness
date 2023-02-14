using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivet : MonoBehaviour
{
    
    public GameObject hook;
    public float speed = 1f;

    //private void FixedUpdate()
    //{
    //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

    //difference.Normalize();

    //float rotationz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

    //transform.rotation = Quaternion.Euler(0f, 0f, rotationz);

    //}

    private void Update()
    {
    Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime );
    }

    
}
