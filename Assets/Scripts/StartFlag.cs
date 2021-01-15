using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlag : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    void Start()
    {
        player.transform.position = transform.position;
    }
}
