using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadClientGameMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Start()
    {
        SceneManager.LoadScene("ClientGameMenu", LoadSceneMode.Additive);
    }
}
