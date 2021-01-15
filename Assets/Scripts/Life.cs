using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject menuGameOver;
    public GameObject[] controls;
    public GameObject[] lifes;

    private int lifePoints = 2;

    private void Start() {
    }

    public void Damage()
    {
        lifes[lifePoints].SetActive(false);
        lifePoints--;

        if(lifePoints < 0){
            menuGameOver.SetActive(true);
            foreach (var item in controls)
            {
                item.SetActive(false);
            }
        }
    }
    
}
