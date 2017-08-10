using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frisbee : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start () {
        //GetComponent<Renderer>().material.color = new Color(0, 255, 0); //C sharp
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            float z = Mathf.Cos(Mathf.PI / 6f) * speed;
            float y = Mathf.Sin(Mathf.PI / 6f) * speed;
            print(z);
            print(y);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, y, z);
            Destroy(this);
        }
    }
}
