using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public GameObject fireball;
    private Animator _anim;

    private float horizontalInput;
    private Rigidbody2D _rb;
    private AudioSource _as;

    public bool isFacingRight = true;
    private bool canJump = true;
    private bool alive = true;

    public bool hasStaff = false;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _as = GetComponent<AudioSource>();
        _anim = GetComponent<Animator>();
    }
    private void Update()
    {

        if (!alive)
            return;

        if (transform.position.y < -5)
            KillPlayer();

        if (Mathf.Abs(_rb.velocity.x) > 0.2)
        {
            _anim.SetBool ("isRun", true);
        }
        else
        {
            _anim.SetBool ("isRun", false);
        }
        
        if (_rb.velocity.y > 0.2)
        {
            _anim.SetBool ("isMovingUp", true);
        }
        else
        {
            _anim.SetBool ("isMovingUp", false);
        }
        
        if (_rb.velocity.y < -0.2)
        {
            _anim.SetBool ("isMovingDown", true);
        }
        else
        {
            _anim.SetBool ("isMovingDown", false);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0)
            isFacingRight = true;
        if (horizontalInput < 0)
            isFacingRight = false;

        if(isFacingRight)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        } else
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (canJump)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, 15);
                _as.Play();
                canJump = false;
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (hasStaff)
            {
                _as.Play();
                Instantiate(fireball, transform.position, Quaternion.identity);
            }
        }
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(horizontalInput * 5, _rb.velocity.y);
    }
    private bool isOnGround()
    {
        return true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            KillPlayer(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        canJump = true;
    }
    public void KillPlayer(GameObject killer)
    {
        Invoke("LoadLevel", 1f);
        GetComponent<SpriteRenderer>().color = Color.red;
        killer.GetComponent<AudioSource>().Play();
        alive = false;
        horizontalInput = 0;
    }
    void KillPlayer()
    {
        Invoke("LoadLevel", 1f);
        GetComponent<SpriteRenderer>().color = Color.red;
        alive = false;
        horizontalInput = 0;
    }
    void LoadLevel()
    {
        SceneManager.LoadScene("AncientEgyptScene");
    }
}
