using UnityEngine;
using System.Collections;

public class LaunchTowards : MonoBehaviour {

	public GameObject player;
	private Vector3 destinationPos;
	private bool shouldMove = false;
	private float waitTime = 2.0f;
	// Use this for initialization
	void Start () {
		StartCoroutine (StartLaunch());
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == destinationPos) {
			shouldMove = false;
//			Lerp.SetLerpTime = 0;
		}

		if (shouldMove) {
			transform.position = Lerp.PerformLerp ();
		}
	}

	public void Launch(float chargeTime) {
		destinationPos = player.transform.position;
		Lerp.InvokeLerp (this.gameObject, destinationPos, chargeTime);
		chargeTime = 0f;
	}
	
	IEnumerator StartLaunch() {
		Debug.Log ("Start LAunch");
		yield return new WaitForSeconds(waitTime);
		Debug.Log ("Done waiting");
		destinationPos = player.transform.position;
		Lerp.InvokeLerp (this.gameObject, destinationPos, 5.0f);
		shouldMove = true;
		StartCoroutine (StartLaunch());

	}
}
