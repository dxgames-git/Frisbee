using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrisbeeController : MonoBehaviour {

    /// <summary>
    /// This class handles Frisbee spawning and sideways oscillation.
    /// </summary>

    // The speed at which the disc oscillates left and right
    public float sidewaySpeed;

    // The absolute value of the amplitude of horizontal oscillation 
    public float sidewayRange;

    // The prefab of the disc being spawned
    public GameObject discPrefab;

    public GameObject currentDisc;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        // If the frisbee hasn't been shot yet, then its Frisbee.cs script won't be null
        if (currentDisc.GetComponent<Frisbee>().shot == false)
        {
            if (currentDisc.transform.position.x > sidewayRange)
            {
                currentDisc.GetComponent<Rigidbody>().velocity = new Vector2(-sidewaySpeed, 0f);
            }
            else if (currentDisc.transform.position.x < -sidewayRange)
            {
                currentDisc.GetComponent<Rigidbody>().velocity = new Vector2(sidewaySpeed, 0f);
            }
        }		
	}

    // Spawns a disc: -1 for left, 1 for right
    public void spawnDisc(int side)
    {
        GameObject newDisc = Instantiate(discPrefab);
        newDisc.transform.position = new Vector3(side * 2f, 0f, -7f);
        currentDisc = newDisc;
    }

}
