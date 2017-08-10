using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

    private BoxCollider goal;
    public Text scoreText;
    private GameObject disc;
    private int scoreCount;
    private float count;
    private float timeScale;

	// Use this for initialization
	void Start () {
        goal = GameObject.FindGameObjectWithTag("goal").GetComponent<BoxCollider>();
        scoreCount = 0;
        count = 0;
        timeScale = 1.7f;
    }
	
	// Update is called once per frame
	void Update () {
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

    public void offCenter()
    {
        count -= 0.01f;
        StartCoroutine("ChangeWidth");
    }

    IEnumerator ChangeWidth()
    {
        float progress = 0;
        Vector3 changeSize = new Vector3(transform.localScale.x + count, transform.localScale.y);
        while (progress <= 1)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, changeSize, progress);
            progress += Time.deltaTime * timeScale;
            yield return null;
        }
        transform.localScale = changeSize;

    }
}
