using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmyHealth : MonoBehaviour {

    public float maxHealth;
    float currentHealth;
	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addDamge(float dame)
    {
        currentHealth = currentHealth - dame;
        if (currentHealth == 0)
        {
            makeDead();
        }
    }

    void makeDead()
    {
        Destroy(gameObject);
    }
}
