using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScaler : MonoBehaviour {

    public float scaleFactor;
    public float distance;

    private Vector3 originalScale;

	// Use this for initialization
	void Start () {
        originalScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        distance = Mathf.Abs(transform.position.z - Camera.main.transform.position.z);//Mathf.Pow(transform.position.z - Camera.main.transform.position.z, 2f) + Mathf.Pow(transform.position.y - Camera.main.transform.position.y, 2f);
        transform.localScale = originalScale * scaleFactor / Mathf.Pow(distance, 3);
	}
}
