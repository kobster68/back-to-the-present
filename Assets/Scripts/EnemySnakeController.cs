using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySnakeController : MonoBehaviour
{

    private bool isTravellingRight = true;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(isTravellingRight)
        {
            _rb.velocity = new Vector2(2, _rb.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
        } else
        {
            _rb.velocity = new Vector2(-2, _rb.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isTravellingRight = !isTravellingRight;
    }

}
