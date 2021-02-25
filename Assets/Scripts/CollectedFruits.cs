using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedFruits : MonoBehaviour
{
    public Text[] textFruits;
    public Text[] textFruitsMissionSucessful;
    public Text[] textFruitsGameOver;
    public Text[] textmenuPause;
    private FruitPoint fruitPoint;

    private void Start() {
        fruitPoint = new FruitPoint();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        GameObject f = other.gameObject;
        FruitCollected(f);
    }

    void FruitCollected(GameObject fruit){
        string tag = fruit.tag;
        if(tag == "Banana")
        {
            fruitPoint.Banana += 1;
            textFruits[0].text = fruitPoint.Banana.ToString();
            textFruitsMissionSucessful[0].text = fruitPoint.Banana.ToString();
            textFruitsGameOver[0].text = fruitPoint.Banana.ToString();
            textmenuPause[0].text = fruitPoint.Banana.ToString();
            Destroy(fruit);
        } else if (tag == "Kiwi")
        {
            fruitPoint.Kiwi += 1;
            textFruits[1].text = fruitPoint.Kiwi.ToString();
            textFruitsMissionSucessful[1].text = fruitPoint.Kiwi.ToString();
            textFruitsGameOver[1].text = fruitPoint.Kiwi.ToString();
            textmenuPause[1].text = fruitPoint.Kiwi.ToString();
            Destroy(fruit);
        } else if (tag == "Orange")
        {
            fruitPoint.Orange += 1;
            textFruits[2].text = fruitPoint.Orange.ToString();
            textFruitsMissionSucessful[2].text = fruitPoint.Orange.ToString();
            textFruitsGameOver[2].text = fruitPoint.Orange.ToString();
            textmenuPause[2].text = fruitPoint.Orange.ToString();
            Destroy(fruit);
        }
    }
}
