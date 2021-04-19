using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Invoke("DestroyFireball", 15f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);
        GetComponent<SpriteRenderer>().flipX = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().KillPlayer(this.gameObject);
        }
    }
    private void DestroyFireball()
    {
        Destroy(this.gameObject);
    }
}
