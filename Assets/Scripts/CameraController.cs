using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject background;

    void Awake()
    {

    }
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z);
        background.transform.position = new Vector3(player.transform.position.x * -0.05f + player.transform.position.x, background.transform.position.y, background.transform.position.z);
    }
}
