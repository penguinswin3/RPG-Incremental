using UnityEngine;
using System.Collections;

public class MainButtonClick : MonoBehaviour {

	public GameObject textBox;

	public void ClickTheButton(){
		textBox.SetActive (true);
	}
}
