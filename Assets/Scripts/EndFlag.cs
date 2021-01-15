using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{

    public GameObject[] disableObject;
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            foreach (var item in disableObject)
            {
                item.SetActive(false);
            }
        }
    }
}
