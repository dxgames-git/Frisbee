using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

    private BoxCollider2D goal;
    public Text scoreText;
    private int scoreCount;

	// Use this for initialization
	void Start () {
        goal = GameObject.FindGameObjectWithTag("goal").GetComponent<BoxCollider2D>();
        scoreCount = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        scoreCount++;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "" + scoreCount;
    }
}
