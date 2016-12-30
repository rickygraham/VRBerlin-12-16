using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using OSCsharp.Data;
using UniOSC;


public class noteattack :  UniOSCEventTarget {

	public GameObject string1;
	public Rigidbody clones1;
	public Rigidbody cubePrefab; //object to be spawned
	public Transform spawnPoint;  //point at which new objects spawn

	public override void OnOSCMessageReceived(UniOSC.UniOSCEventArgs args){

		OscMessage msg = (OscMessage)args.Packet;
		float grav_f = (float)msg.Data[0];
		if(grav_f == 1.1f) {
			Rigidbody cubeInstance;
			cubeInstance = Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation) as Rigidbody; //substitute spawn point with current sphere transform
			cubeInstance.AddForce(spawnPoint.forward * 100); //substitute 100 with value from string
			cubeInstance.name = "clonesofcubes_1";  // Set the instance name to control mass and drag of all clones
			string1 = GameObject.Find("cloneofcubes_1");

			cubeInstance.mass = (float)msg.Data[1];

			//cloneObj.rigidbody.velocity = (float)msg.Data[1];
			//cloneObj.rigidbody.useGravity = (float)msg.Data[1];
			//clones1.mass = (float)msg.Data[0];
			//clones1.drag = (float)msg.Data[1];
			//rb.angularDrag = (float)msg.Data[2];
	
		}
	

	}


	void Awake(){
	}

	void Start() {
	}
		
	void Update() { 
	}


}