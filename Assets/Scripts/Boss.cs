using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public Slider life;
    public GameObject zerou;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(life.value <=0){
            zerou.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Bullet"){
            life.value -= 10;
            if (life.value == 900 
                || life.value == 800 
                || life.value == 700
                || life.value == 600
                || life.value == 500
                || life.value == 400
                || life.value == 300
                || life.value == 200
                || life.value == 100)
            {
                anim.SetInteger("transition", 2);
            }
        }
    }
}
