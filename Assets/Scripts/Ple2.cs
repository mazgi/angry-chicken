using UnityEngine;
using System.Collections;

public class Ple2 : MonoBehaviour {
	
	private float unit = 0.02f;
	
	private float startX = 0.0f;
	private float startY = 0.0f;
	
	private float currentX = 0.0f;
	private float currentY = 0.0f;

	// Use this for initialization
	void Start () {
		startX = transform.position.x;
		startY = transform.position.y;
		currentX = startX;
		currentY = startY;
	}
	
	// Update is called once per frame
	void Update () {
		currentX = transform.position.x + unit;
		if (Mathf.Abs(currentX - startX) > Mathf.Abs(unit * 3.0f)) {
			unit *= -1.0f;
		}
		this.gameObject.transform.position = new Vector3(
			currentX,
			currentY,
			0.0f);
	}
}
