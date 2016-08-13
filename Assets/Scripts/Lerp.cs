using UnityEngine;
using System.Collections;

public class Lerp {
    

	static float lerpTime = 1f;
    static float currentLerpTime;
	static float speed = 10f;
 
    // float moveDistance = 10f;
// 	static GameObject lerpObject;
	static Vector3 startPos;
	static Vector3 endPos;
	public static bool currentlyLerping = false;

    public static void InvokeLerp(GameObject objectToLerp, Vector3 endPosition, float time) 
	{
//    	lerpObject = objectToLerp;
    	startPos = objectToLerp.transform.position;
    	endPos = endPosition;
    	lerpTime = time;
		currentLerpTime = 0;
    	currentlyLerping = true;
    }
 
	public static Vector3 PerformLerp() 
	{
        if (Input.GetKeyDown(KeyCode.Space)) {
            currentLerpTime = 0f;
        }
 
        //increment timer once per frame
		currentLerpTime += (Time.deltaTime * speed);
        if (currentLerpTime > lerpTime) {
            currentLerpTime = lerpTime;
        }
 
        //lerp!
        float perc = currentLerpTime / lerpTime;
		return Vector3.Lerp(startPos, endPos, perc);
    }

	public static void SetLerpTime(float newTime)
	{
		currentLerpTime = newTime;
	}
}