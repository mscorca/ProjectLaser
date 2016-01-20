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
		float transVert = 0;
		float transHoriz = 0;

		Debug.Log("Vertical: " + Input.GetAxis("Vertical2"));
		Debug.Log("Horizontal: " + Input.GetAxis("Horizontal2"));

        if(Mathf.Abs(Input.GetAxis("Vertical2")) > 0.01 ){
        	transVert = Input.GetAxis("Vertical2") * speed * Time.deltaTime;
        }
        transHoriz = Input.GetAxis("Horizontal2") * speed * Time.deltaTime;
       	
       	transform.Translate(transHoriz, transVert, 0);		
	}
}
