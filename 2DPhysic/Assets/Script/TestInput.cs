using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamePhysic;

public class TestInput : MonoBehaviour {
    public PhysicComponent Physic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 Speed = new Vector2();
		if( Input.GetKey(KeyCode.D))
        {
            Speed.x = 10;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            Speed.x = -10;
        }
        if(Input.GetKey(KeyCode.W))
        {
            Speed.y = 10;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            Physic.LeavePlatform();
        }
        Physic.MoveSpeed = Speed;

    }
}
