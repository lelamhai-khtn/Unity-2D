using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMe : MonoBehaviour {

    public float alive;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, alive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
