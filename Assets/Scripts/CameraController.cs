using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject background;
    public float cameraY;

    void Awake()
    {

    }
    void Update()
    {
        cameraY = 1.5f;

        if (player.transform.position.y > 5)
        {
            cameraY = player.transform.position.y - 3.5f;
        }
        this.transform.position = new Vector3(player.transform.position.x, cameraY, this.transform.position.z);

        //Paralax
        background.transform.position = new Vector3(player.transform.position.x * -0.05f + player.transform.position.x, background.transform.position.y, background.transform.position.z);
    }
}
