using UnityEngine;
using System.Collections;

public class globescript : MonoBehaviour {

	public int speed =8;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.back * Time.deltaTime*speed);

	}
}
