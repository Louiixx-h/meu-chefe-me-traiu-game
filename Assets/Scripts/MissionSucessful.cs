using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSucessful : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("fase_inicial");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("fase_boss");
    }
}
