using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    
    public GameObject menuPause;

    public void PauseGame()
    {
        Time.timeScale=0;
        menuPause.SetActive(true);
            
    }

    public void ResumeGame()
    {
        Time.timeScale=1;
        menuPause.SetActive(false);
    }
}

