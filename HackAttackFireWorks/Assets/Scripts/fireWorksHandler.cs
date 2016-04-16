using UnityEngine;
using System.Collections;

public class fireWorksHandler : MonoBehaviour {

	public GameObject fireworks;
	private bool fireworksActive;
	public ParticleEmitter fire;

	// Use this for initialization
	void Start () {
		fireworksActive = false;
		//fireworks.SetActive(fireworksActive);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1"))
		{
			fireworksActive = !fireworksActive;
			//fireworks.SetActive(fireworksActive);
			fire.emit = fireworksActive;
		}
	
	}
}
