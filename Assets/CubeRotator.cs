using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var addAngle = this.speed * Time.deltaTime;
        this.transform.rotation = Quaternion.Euler(addAngle, addAngle, addAngle) * this.transform.rotation;
	}
}
