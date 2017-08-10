using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frisbee : MonoBehaviour {

    public bool shot;

    public float speed;

    // Use this for initialization
    void Start () {
        //GetComponent<Renderer>().material.color = new Color(0, 255, 0); //C sharp
        shot = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            shot = true;
            float z = Mathf.Cos(Mathf.PI / 6f) * speed;
            float y = Mathf.Sin(Mathf.PI / 6f) * speed;
            print(z);
            print(y);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, y, z);
            GameObject.FindGameObjectWithTag("FrisbeeController").GetComponent<FrisbeeController>().spawnDisc(((int) (Random.value * 3f)) - 1);
            Destroy(this);
        }
    }
}
