using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject character1;
	public GameObject character2;
	public GameObject laserObject;
	public RaycastHit2D rayHit;
	public float waitTime = 3.5f;

	private Vector3 player1Position;
	private Vector3 player2Position;

	[HideInInspector] public LineRenderer laser;

	// Use this for initialization
	void Start () {
		laser = laserObject.GetComponent<LineRenderer>();
		StartCoroutine (RepeatLaser());
		Debug.Log("controller count: " + Input.GetJoystickNames().Length + "\nJoystcik name: ");
	}
	
	// Update is called once per frame
	void Update () {
		if(laserObject.active) MoveLaser();
	}

	void MoveLaser() {
		player1Position = character1.transform.position;
		player2Position = character2.transform.position;
		laser.SetPosition(0, player1Position);
		laser.SetPosition(1, player2Position);
	}

	void ShootLaser() {
		MoveLaser();
		laserObject.SetActive(true);

		Vector2 castDirection = character2.transform.position - character1.transform.position;
		Debug.Log("Cast direction magnitude: " + castDirection.magnitude);

		Debug.DrawLine(character1.transform.position, character2.transform.position, Color.green, 5.0f, true);
		Debug.Log("Character1 pos: " + character1.transform.position);

		rayHit = Physics2D.Raycast(character1.transform.position, castDirection, castDirection.magnitude);

		if(rayHit.collider != null){
			Debug.Log("hit ");		
			Debug.Log("Name : " + rayHit.collider.name);
			Destroy(rayHit.collider.gameObject);
		}
		StartCoroutine(StopLaser());
	}

	IEnumerator StopLaser() {
        yield return new WaitForSeconds(0.2f);
		laserObject.SetActive(false);
	} 
 
	IEnumerator RepeatLaser()
	{
		yield return new WaitForSeconds(waitTime);
		print ("shooting laser again");
		ShootLaser();
		StartCoroutine (RepeatLaser());
	}
}
