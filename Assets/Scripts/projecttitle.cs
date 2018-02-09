using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projecttitle : MonoBehaviour {

    public float bulletSpeed;
    Rigidbody2D mybody;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        // lam vien dan bay
        // ForceMode2D.Impulse tao 1 luc de cho vien dan bay di
        if(transform.localRotation.z > 0)
        {
            mybody.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse);
        }
        else
        {
            mybody.AddForce(new Vector2(1, 0) * bulletSpeed, ForceMode2D.Impulse);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void removeForce()
    {
        mybody.velocity = new Vector2(0,0);
    }
}
