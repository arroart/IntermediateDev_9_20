using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinScreen;
    public GameObject StartScreen;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemoveScreen", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Box")
        {
            WinScreen.gameObject.SetActive(true);
        }
    }
    void RemoveScreen()
    {
        StartScreen.gameObject.SetActive(false); ;
    }
}
