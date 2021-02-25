using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{

    public string scene;

    public void ToScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void About()
    {
        Application.OpenURL("https://beacons.page/louis.henrik");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
