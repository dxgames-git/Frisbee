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
            float z = Mathf.Cos(-1f * transform.rotation.x) * speed;
            float y = Mathf.Sin(-1f * transform.rotation.x) * speed;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, y, z);
            Destroy(this);
        }
    }
}
