using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour {
	public float speed = 1;
	public int playerNum;


	public void Update(){
		Move();
	}

	public void Move() 
	{
        float transVert = Input.GetAxis("Vertical2") * speed * Time.deltaTime;
        float transHoriz = Input.GetAxis("Horizontal2") * speed * Time.deltaTime;
        transform.Translate(transHoriz, transVert, 0);
	}
}
