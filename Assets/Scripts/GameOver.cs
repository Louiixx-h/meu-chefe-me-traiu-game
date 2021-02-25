using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string fase;
    public string menu;

    private void Start() {
        Time.timeScale=0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(fase);
        Time.timeScale=1;
    }
    public void ClickExit()      
    {
        SceneManager.LoadScene(menu);
        Time.timeScale=1;
    }
}
