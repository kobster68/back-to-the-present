using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AncientStaff : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter2D(Collision2D col)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        player.GetComponent<PlayerController>().hasStaff = true;

    }
}
