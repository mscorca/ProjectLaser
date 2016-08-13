using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SpawnEnemy()
	{
		yield return new WaitForSeconds(1.0f);
		Instantiate (enemyPrefab);
		Debug.Log ("spawn wenemy");
		StartCoroutine (SpawnEnemy());
	}
}
