using UnityEngine;
using System.Collections;

public class rocketscript : MonoBehaviour {

	GameObject explosion;
	GameObject powerup;

	// Use this for initialization
	void Start () {
	
		explosion = (GameObject)Resources.Load("Prefabs/Explosion", typeof(GameObject));

		if (Random.value > 0.5) {
			powerup = (GameObject)Resources.Load ("Prefabs/Crown", typeof(GameObject));
		} else if (Random.value > 0.5){
			powerup = (GameObject)Resources.Load ("Prefabs/Cash", typeof(GameObject));
		}
		else{
			powerup = (GameObject)Resources.Load ("Prefabs/PhoneBox", typeof(GameObject));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.GetComponent<Rigidbody> ().velocity.y < 0) {
			Destroy (gameObject);

			GameObject explosionClone = (GameObject) Instantiate(explosion, transform.position, transform.rotation);

			if (Random.value > 0.8) {
				GameObject PowerUp = (GameObject)Instantiate (powerup, transform.position, transform.rotation);
			}
		}
	}
}
