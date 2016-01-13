using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour {
	public float speed = 1;
	public int playerNum;


	public void Update(){
		Move();
	}

	public void Move() 
	{
        float transVert = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float transHoriz = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(transHoriz, transVert, 0);
	}
}
