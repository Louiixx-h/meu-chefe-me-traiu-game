using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 400f;
    private GameObject[] heroObj;
    private Hero hero;
    private bool fired = false;

    private void Start() {
        heroObj = GameObject.FindGameObjectsWithTag("Player");
        hero = heroObj[0].GetComponent<Hero>();
    }

    private void Update() {
        if (!fired)
        {
            if (!hero.flip)
            {
                rb.velocity = transform.right * speed * Time.deltaTime;
                fired = !fired;
            } else {
                rb.velocity = new Vector2(-1 * speed * Time.deltaTime, rb.velocity.y);
                fired = !fired;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
    }
}
