using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 1.5f;
	public GameObject character1;
//	public GameObject character2;

	private GameObject target;

	void Start(){
		character1 = GameObject.Find ("Player1");
	}

	// Update is called once per frame
	void Update () {
//		float dist1 = Vector2.Distance(transform.position, character1.transform.position);
//		float dist2 = Vector2.Distance(transform.position, character2.transform.position);
//
//		if(target != character1 && dist1 < dist2){
//			target = character1;
//		} 
//		if(target != character2 && dist1 > dist2) {
//			target = character2;
//		}
//
		transform.position = Vector2.MoveTowards(transform.position, character1.transform.position, speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log("collider: "  + coll.gameObject.name);
		if (coll.gameObject.name == "Ghost") 
		{
			GameObject.Destroy (this.gameObject);
		}
	}

}
