using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           //transform.rotation += new Quaternion Transform.rotation
        }
    }
}
