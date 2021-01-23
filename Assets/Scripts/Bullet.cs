using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 400f;
    private GameObject[] heroObj;
    private Hero hero;

    private void Start() {
        heroObj = GameObject.FindGameObjectsWithTag("Player");
        hero = heroObj[0].GetComponent<Hero>();
    }

    private void Update() {
        
        if (hero.flip == false)
        {
            rb.velocity = transform.right * speed * Time.deltaTime;
        } else {
            rb.velocity = new Vector2(-1 * speed * Time.deltaTime, rb.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
    }
}
