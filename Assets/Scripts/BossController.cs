using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{

    public GameObject fireball;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShootFireball", 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void ShootFireball()
    {
        Instantiate(fireball, transform.position, Quaternion.identity);
        Invoke("ShootFireball", 3f);
    }
}
