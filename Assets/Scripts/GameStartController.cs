using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartController : MonoBehaviour
{
    [SerializeField] private GameObject pauseCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            pauseCanvas.GetComponent<Canvas>().enabled = false;
        }
        
    }
}
