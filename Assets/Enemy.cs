using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject player;
    public float speed;
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform.position);
        transform.Translate(0, 0, speed * Time.deltaTime);

	}
    void OnCollisionStay(Collision Obj)
    {
        if(Obj.gameObject.name == "Player")
        {
            speed = 0f;
        }
        else
        {
            speed = 5f;
        }
    }
}
