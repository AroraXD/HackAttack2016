using UnityEngine;
using System.Collections;

public class menuhandler : MonoBehaviour {

	public GameObject game;
	public GameObject menu;
	public GameObject optionMenu;

	// Use this for initialization
	void Start () {
	
		game.SetActive (false);
		menu.SetActive (true);
		optionMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame()
	{
		game.SetActive (true);
		menu.SetActive (false);
		optionMenu.SetActive (false);
	}

	public void showOptionsMenu()
	{
		game.SetActive (false);
		menu.SetActive (false);
		optionMenu.SetActive (true);
	}

	public void showMenu()
	{
		game.SetActive (false);
		menu.SetActive (true);
		optionMenu.SetActive (false);
	}
}
