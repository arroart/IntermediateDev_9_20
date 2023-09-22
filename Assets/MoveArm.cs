using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    private Rigidbody2D rb;
    float mypower = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up*mypower, ForceMode2D.Impulse);
        }
    }
}
