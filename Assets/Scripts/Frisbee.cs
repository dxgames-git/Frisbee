using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frisbee : MonoBehaviour {

    public bool shot;
    public float speed;
    private GameObject goal;

    // Use this for initialization
    void Start () {
        //GetComponent<Renderer>().material.color = new Color(0, 255, 0); //C sharp
        shot = false;
        goal = GameObject.FindGameObjectWithTag("goal");
    }
	
	// Update is called once per frame
	void Update () {
        //if (Mathf.Abs(goal.transform.position.y - gameObject.transform.position.y) < 1)
        //{
            //checkDistance();
        //}
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            shot = true;
            float z = Mathf.Cos(Mathf.PI / 180f * (360f - transform.eulerAngles.x)) * speed;
            float y = Mathf.Sin(Mathf.PI / 180f * (360f - transform.eulerAngles.x)) * speed;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, y, z);
            checkDistance();
            GameObject.FindGameObjectWithTag("FrisbeeController").GetComponent<FrisbeeController>().spawnDisc(Random.value < 0.5 ? -1 : 1);
            Destroy(this);
        }
    }

    void checkDistance()
    {
        if (Mathf.Abs(goal.transform.position.x - gameObject.transform.position.x) > 1.5)
        {
            goal.GetComponent<GoalController>().offCenter();
        }
    }
}
