using UnityEngine;
using System.Collections;

public class menuhandler : MonoBehaviour {

	public GameObject game;
	public GameObject menu;

	// Use this for initialization
	void Start () {
	
		game.SetActive (false);
		menu.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame()
	{
		game.SetActive (true);
		menu.SetActive (false);
	}
}
