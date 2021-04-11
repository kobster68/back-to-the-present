using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public bool isFacingRight;
    public GameObject player;

    private void Awake()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        isFacingRight = player.GetComponent<PlayerController>().isFacingRight;
        Invoke("RemoveObject", 1L);

    }

    void Update()
    {
        if(isFacingRight)
        {

            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);

        } else
        {
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    void RemoveObject()
    {
        Destroy(this.gameObject);
    }
}
