using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadLevel", 20f);
    }
    void LoadLevel()
    {
        SceneManager.LoadScene("AncientEgyptScene");
    }

}
