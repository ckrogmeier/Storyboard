using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;



public class changeMat : MonoBehaviour {



	public SteamVR_Input_Sources handType;
	public SteamVR_Action_Boolean teleportAction;
	public SteamVR_Action_Boolean grabAction;

	public SteamVR_Action_Boolean GrabPinch;

	public Material[] materials;
	private MeshRenderer meshrenderer;

	public int arrayIndex = 0;

	void Start () {

		meshrenderer = GetComponent<MeshRenderer> ();
		//materials = new Material[7];
		//controller = GetComponent<SteamVR_TrackedController> ();

	}
	
	// Update is called once per frame
	void Update () {

		//or can use Teleport for touchpad control

		if (SteamVR_Actions._default.myTrigger.GetStateUp(SteamVR_Input_Sources.Any) || Input.GetKeyDown(KeyCode.Space)) {

			if (arrayIndex != materials.Length - 1) {

				arrayIndex++;
				meshrenderer.material = materials [arrayIndex];
				Debug.Log ("teleport has been pressed.");
						
			} else {
				arrayIndex = 0;
				meshrenderer.material = materials [arrayIndex];
				Debug.Log ("index reset");
			}

		}





	}



	public bool GetTeleportDown() {

		return teleportAction.GetStateDown(handType);
	}


	public bool GetGrab()
	{
		return grabAction.GetState (handType);
	}


}
