using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	GameObject panel;
	void Start(){
		panel = GameObject.Find("EndPopup");
		panel.SetActive (false);

	}
	// Update is called once per frame
	void FixedUpdate () {

		if (GameObject.FindGameObjectsWithTag ("Ball").Length <= 1 && GameObject.Find ("Player") != null) {
			panel.SetActive (true);
			Color temp = Color.green;
			temp.a = .3f;
			GameObject.Find ("ConnotationPanel").GetComponent<Image> ().color = temp;
			GameObject.Find ("EndingText").GetComponent<Text>().text = "You won!";
			GameObject.Find ("RestartText").GetComponent<Text>().text = "Go Again?";
		}
		else if (GameObject.Find ("Player") == null && GameObject.FindGameObjectsWithTag ("Ball").Length >= 1) {
			panel.SetActive (true);
			Color temp = Color.red;
			temp.a = .3f;
			GameObject.Find ("ConnotationPanel").GetComponent<Image> ().color = temp;
			GameObject.Find ("EndingText").GetComponent<Text>().text = "You got knocked off...";
			GameObject.Find ("RestartText").GetComponent<Text>().text = "Try Again?";
		} 
	}

	public void ResetRound(){
		SceneManager.LoadScene ("GameScene");
	}
}
