using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TextControllerv2 : MonoBehaviour {

	public Text text; 
	private enum States {cell, sheets_0, mirror, lock_0, sheets_1, cell_mirror, lock_1, freedom}; 
	private States myState; 


	// Use this for initialization
	void Start () {
		myState = States.cell; 

	}
	
	// Update is called once per frame
	void Update () {
		print (myState); 

		if (myState == States.cell) {
			cell (); 
		} else if (myState == States.sheets_0) {
			sheets_0 (); 
		} else if (myState == States.mirror) {
			mirror (); 
		} else if (myState == States.cell_mirror) {
			cell_mirror(); 
		}
	
	}

	void cell(){
		text.text = "You are inside the cell, you see three items:\n\n " +
			"Sheets\n" +
			"A Mirror\n" + 
			"A Lock\n" + 
			"Press S for sheets, M for Mirror, and L for the Lock"; 
		if (Input.GetKeyDown(KeyCode.S)){
			myState =States.sheets_0; 
		} else if (Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror; 
		} else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0; 
		}

	}
	void sheets_0(){
		text.text = "What is with these sheets, nothing special to see here.\n" + 
					"Press R to return to the cell"; 

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell; 
		}
	}

	void mirror(){
		text.text = "Wow you find a cool looking mirror, doesn't do much...\n" +
					"Press T to take the mirror\n" + 
					"Press R to return to the cell";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror; 
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell; 
		}
	}

	void cell_mirror(){


	}
}
