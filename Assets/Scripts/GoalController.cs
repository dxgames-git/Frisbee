using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

    private BoxCollider2D goal;
    public Text scoreText;
    private int scoreCount;
    private float count;

	// Use this for initialization
	void Start () {
        goal = GameObject.FindGameObjectWithTag("goal").GetComponent<BoxCollider2D>();
        scoreCount = 0;
        count = 0;
    }
	
	// Update is called once per frame
	void Update () {
       /* if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            count -= 0.1f;
            changeWidth(count);
        }*/
	}

     void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        scoreCount++;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "" + scoreCount;
    }

    void changeWidth(float count)
    {
        Vector3 changeSize = new Vector3(transform.localScale.x + count, transform.localScale.y); //stop decreasing the size of the width when it hits a certain extent
        transform.localScale = changeSize;
        Vector2 s = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        gameObject.GetComponent<BoxCollider2D>().size = s;
    }
}
