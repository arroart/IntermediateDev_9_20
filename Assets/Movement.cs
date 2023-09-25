using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject f_leg;
    public GameObject b_leg;
    Rigidbody2D fLegRB;
    Rigidbody2D bLegRB;

    public Animator anim;

    public float speed=1.5f;
    public float stepWait = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        fLegRB = f_leg.gameObject.GetComponent<Rigidbody2D>();
        bLegRB = f_leg.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey("D"))
            {
            fLegRB.AddForce(Vector2.left * (speed * 1000) * Time.deltaTime);
            anim.Play("WalkRight");
                StartCoroutine(MoveRight(stepWait));
            Debug.Log("aa");
            }
            if (Input.GetKey("A"))
            {
                anim.Play("WalkLeft");
                StartCoroutine(MoveLeft(stepWait));
            }
        else
        {
            anim.Play("Idle");
        }
    }
    
    IEnumerator MoveRight(float seconds)
    {
        bLegRB.AddForce(Vector2.right * (speed * 1000) * Time.deltaTime);
        yield return new WaitForSeconds(seconds);
        fLegRB.AddForce(Vector2.right * (speed * 1000) * Time.deltaTime);
    }

    IEnumerator MoveLeft(float seconds)
    {
        fLegRB.AddForce(Vector2.left * (speed * 1000) * Time.deltaTime);
        yield return new WaitForSeconds(seconds);
        bLegRB.AddForce(Vector2.left * (speed * 1000) * Time.deltaTime);
    }
}
