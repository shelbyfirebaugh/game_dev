using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class adventure : MonoBehaviour {

	public Camera mainCam;

	public string currentRoom;
	public string myText;

	private bool hasKey = false;
	private bool hasNote = false;
	private bool hasCode = false;

	private string roomUp;
	private string roomDown;
	private string roomRight;
	private string roomLeft;

	// Use this for initialization
	void Start () {

		myText = "scene run";
		currentRoom = "title";
	
	}
	
	// Update is called once per frame
	void Update () {

		roomUp = "nil";
		roomDown = "nil";
		roomRight = "nil";
		roomLeft = "nil";

		mainCam.backgroundColor = Color.black;
		GetComponent<Text>().color = Color.white;


		if (currentRoom == "title") {
			myText = "mouse trap\n\nby shelby firebaugh\n\npress space to begin";

			if (Input.GetKeyDown (KeyCode.Space)) {
				currentRoom = "mouse hole";
			}
		} else if (currentRoom == "mouse hole") {
			roomDown = "hallway";

			myText = "this is your mouse hole.\n\nin here, you are safe from all of the cats that are lurking outside.\n\nbut alas...you must leave your safe haven. no longer can you stand to live in this cage.\n\nyou want to see the ocean.";
		} else if (currentRoom == "hallway") {
			roomUp = "mouse hole";
			roomDown = "living room";
			roomLeft = "kitchen";

			myText = "you're in the hallway";
		} else if (currentRoom == "kitchen") {
			roomRight = "hallway";

			if (hasKey) {
				currentRoom = "locked kitchen";
			} else {
				myText = "you're in the kitchen.\n\noh no! there's a cat eating from its bowl in the kitchen!\n\nhurry! make your silent retreat before it notices you....";
			}

		} else if (currentRoom == "locked kitchen") {
			myText = "you locked this cat in the kitchen. good job!\n\npress space to return to the hallway";

			if (Input.GetKeyDown (KeyCode.Space)) {
				currentRoom = "hallway";
			}

		} else if (currentRoom == "living room") {
			roomUp = "hallway";
			roomDown = "another hallway";
			roomRight = "bedroom";

			myText = "you're in the living room.";

			if (!hasNote) {
				myText += "you see something catch the light under the couch. press \"i\" to inspect.";
				if (Input.GetKeyDown (KeyCode.I)) {
					currentRoom = "couch";
				}
			}
		} else if (currentRoom == "couch") {
			myText = "there's a curious note under the couch. it says \"x=3 and y=5\"\n\nstrange.\n\npress space to return to the living room";
			hasNote = true;

			if (Input.GetKeyDown (KeyCode.Space)) {
				currentRoom = "living room";
			}
		} else if (currentRoom == "bedroom") {
			roomLeft = "living room";

			if (hasKey) {
				currentRoom = "locked bedroom";
			} else {
				myText = "you're in the bedroom.\n\noh no! there's a cat sleeping on the bed in here!\n\nrun away~";
			}

		} else if (currentRoom == "locked bedroom") {
			myText = "you locked this cat in the bedroom. good job!\n\npress space to return to the living room";

			if (Input.GetKeyDown (KeyCode.Space)) {
				currentRoom = "living room";
			}
		} else if (currentRoom == "another hallway") {
			roomUp = "living room";
			roomDown = "corner room";
			roomLeft = "laundry room";

			myText = "ah, another hallway. nothing much to see here";
		} else if (currentRoom == "laundry room") {
			roomRight = "another hallway";

			myText = "you're in the laundry room.";

			if (!hasKey) {
				myText += "you see a key hanging on a hook. press \"c\" to climb up to them.";
				if (Input.GetKeyDown (KeyCode.C)) {
					currentRoom = "key";
				}
			}
		} else if (currentRoom == "key") {
			myText = "maybe this key locks the doors! you take it with you.\n\npress space to return to the laundry room.";
			hasKey = true;

			if (Input.GetKeyDown (KeyCode.Space)) {
				currentRoom = "laundry room";
			}
		} else if (currentRoom == "corner room") {
			roomUp = "another hallway";
			roomRight = "entryway";

			myText = "you're in the corner room.\n\nbut what's that room to the right?\n\nyou've never been in there before....";
		} else if (currentRoom == "entryway") {
			roomLeft = "corner room";

			myText = "you're in the entryway. the door is locked, but you notice something odd next to it.\n\nupon further inspection, you realize it's a keypad.\n\npress\"c\" to climb up to it.";
			if (Input.GetKeyDown (KeyCode.C)) {
				currentRoom = "keypad";
			}
		} else if (currentRoom == "keypad") {

			roomRight = "garage";
			roomLeft = "corner room";

			myText = "you wonder what the code could be....\n\non the screen it says \"x+y\".\n\nenter your best guess.";

			if (Input.GetKeyDown(KeyCode.Alpha8)) {
					myText = "you unlocked the door!";
				hasCode = true;
			}

			if(
			} else if (currentRoom == "garage") {
			roomLeft = "entryway";

			myText = "you're in the garage. it's dark and a little bit scary...\n\nbut you spy a sliver of light across the room!\n\nyou approach, and discover that there is a small hole in the wall.\n\nyou squeeze through and...\n\noutside, the breeze smells like freedom.\n\nand perhaps a hint of sea water....";
		}


		myText += "\n\n";
		if (roomUp != "nil"){

			myText += "press up to go to the " + roomUp + "\n";

			if (Input.GetKeyDown(KeyCode.UpArrow)) {

				currentRoom = roomUp;

			}
		}


		if (roomDown != "nil"){

			myText += "press down to go to the " + roomDown + "\n";

			if (Input.GetKeyDown(KeyCode.DownArrow)){


				currentRoom = roomDown;

			}
		}

		if (roomRight != "nil"){

			myText += "press right to go to the " + roomRight + "\n";

			if (Input.GetKeyDown(KeyCode.RightArrow)){

				currentRoom = roomRight;

			}
		}

		if (roomLeft != "nil") {

			myText += "press left to go to the " + roomLeft + "\n";

			if (Input.GetKeyDown(KeyCode.LeftArrow)){

				currentRoom = roomLeft;

			}
		}

		//We are acccesing the text component, then using dot notation
		//to modify the text attribute.
		GetComponent<Text>().text = myText;




	}
}
