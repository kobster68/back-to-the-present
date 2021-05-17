using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeCrystal : MonoBehaviour
{ 
    void OnCollisionEnter2D(Collision2D col)
    {
        Invoke("LoadLevel", 1f);
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }
    void LoadLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
