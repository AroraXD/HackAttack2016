using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class fireWorksHandler : MonoBehaviour {

	public Rigidbody rocket;
	public float speed = 10f;
	public float power = 10f;
	public GameObject PowerUI;
	public GameObject SpeedUI;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1"))
		{
			setSpeed();
			fireRocket();
		}

		SpeedUI.GetComponent<Text>().text = "Speed: "+  (int)speed;
		PowerUI.GetComponent<Text>().text = "Power: "+ power;
	}
		
	public void fireRocket()
	{
		Rigidbody rocketClone = (Rigidbody) Instantiate(rocket);

	rocketClone.velocity = transform.up * speed;
	}

	public void setSpeed() {
		
		speed = Random.value * 10f;
	
	}

	public void resetValues()
	{
		speed = 0f;
		power = 0f;
	}
}