using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject checkpoint;
    public GameObject player;
    private Vector3 respawnPos;
    // Start is called before the first frame update
    void Start()
    {
        respawnPos = new Vector3(checkpoint.transform.position.x, 2.5f, player.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Comma))
        {
            player.transform.position = respawnPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Checkpoint"))
        {
            checkpoint = collision.gameObject;
            respawnPos = new Vector3(checkpoint.transform.position.x, 2.5f, player.transform.position.z);
        }
        if(collision.CompareTag("Boundary"))
        {
            Debug.Log("Hello");
            player.transform.position = respawnPos;
        }
    }

}
