﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFilling : MonoBehaviour {

    private int count;
    
    // Use this for initialization
	void Start ()
    {
        count = 0;
        transform.localScale = new Vector3(2, 0.1f, 2);
        transform.localPosition = new Vector3(-0.78f, -0.8f, 2.16f);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Water")
        {
            if(count < 3)
            {
                transform.localScale = new Vector3(2, transform.localScale.y + 0.1f, 2);
                transform.localPosition = new Vector3(0, transform.localScale.y + 0.1f, 0);
                count += 1;
            }

            else
            {
                GameObject.Find("faucet").GetComponent<WaterSpawn>().enabled = false;
            }

        }
    }
}
