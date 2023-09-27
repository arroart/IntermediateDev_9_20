using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float xOffset;
    public float yOffset;
    public float offsetSmoothing;
    private Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = new Vector3(player.transform.position.x- xOffset, player.transform.position.y-yOffset, transform.position.z) ;
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y + yOffset, transform.position.z);

        if(player.transform.localScale.x > 0f)
        {
           playerPos = new Vector3(player.transform.position.x + xOffset, playerPos.y, playerPos.z);
        }
        else
        {
            playerPos = new Vector3(player.transform.position.x - xOffset, playerPos.y, playerPos.z);
        }
        transform.position = Vector3.Lerp(transform.position, playerPos, offsetSmoothing*Time.deltaTime);
    }
}
