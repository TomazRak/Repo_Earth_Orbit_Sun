using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, 5 * Time.deltaTime);
        transform.Rotate(0, 0.5f, 0);
    }
}
