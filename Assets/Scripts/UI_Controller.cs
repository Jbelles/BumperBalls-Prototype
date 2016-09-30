using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour {

	public void onPlayClicked(){
		SceneManager.LoadScene ("GameScene");
	}
}
