using UnityEngine;
using System.Collections;
public class InventoryScreen : MonoBehaviour {
	GameObject Canvas;
	void Awake(){
		Canvas = GameObject.Find ("Canvas");
		Canvas.SetActive (false);
	}
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.G)) {
			Canvas.SetActive (!Canvas.activeInHierarchy);
			UnityStandardAssets.Characters.FirstPerson.MouseLook.CamMouseMove = !UnityStandardAssets.Characters.FirstPerson.MouseLook.CamMouseMove;

		}
	}

}