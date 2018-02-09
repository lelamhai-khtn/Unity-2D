using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour {

    public float weaponDamge;
    projecttitle myPC;
    public GameObject bulletExplostion;

    private void Awake()
    {
        myPC = GetComponentInParent<projecttitle>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "shootable")
        {
            myPC.removeForce();
            Instantiate(bulletExplostion,transform.position, transform.rotation);
            Destroy(gameObject);

            if(collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enmyHealth hurtEnemy = collision.gameObject.GetComponent<enmyHealth>();
                hurtEnemy.addDamge(weaponDamge);
                
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shootable")
        {
            myPC.removeForce();
            Instantiate(bulletExplostion, transform.position, transform.rotation);
            Destroy(gameObject);
            if (collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enmyHealth hurtEnemy = collision.gameObject.GetComponent<enmyHealth>();
                hurtEnemy.addDamge(weaponDamge);

            }
        }
    }
}
