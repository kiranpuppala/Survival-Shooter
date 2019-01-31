using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTop : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
		transform.Rotate(Vector3.up,20f*Time.deltaTime);
	}
}
