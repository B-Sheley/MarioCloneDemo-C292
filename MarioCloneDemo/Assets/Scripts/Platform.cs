using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class Platform : MonoBehaviour
{
    [SerializeField] float speed;
    private float startLocation;
    private float endLocation;
    [SerializeField] float distance;
    private Vector3 direction = Vector3.up;
    private bool playerLanded = false;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position.y;
        endLocation = startLocation + distance;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLanded == true) {
            transform.Translate(direction * speed * Time.deltaTime);

            if (transform.position.y >= endLocation) { direction = Vector3.down; }
            if (transform.position.y <= startLocation) { direction = Vector3.up; }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerLanded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerLanded = false;
        }
    }
}
