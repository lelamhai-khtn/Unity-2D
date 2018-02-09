using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth;
    float currentHealth;

    public GameObject bloodEffect;
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
        Instantiate(bloodEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
