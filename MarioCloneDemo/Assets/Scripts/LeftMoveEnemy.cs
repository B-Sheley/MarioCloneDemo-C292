using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMoveEnemy : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private int movePoint = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movePoint * Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy(collision.gameObject);
            Debug.Log("You been hit");
        }
        if (collision.gameObject.tag == "wall")
        {
            Debug.Log("change");
            movePoint *= -1;
        }
    }


}
