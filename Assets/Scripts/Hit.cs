using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
	public float limitVel = 2.0f;
	public float oldValue = 0.0f;

	void OnCollisionStay(Collision collisionInfo)
	{
		float diff = Mathf.Abs(oldValue - collisionInfo.relativeVelocity.magnitude);
		if(diff > limitVel) {
			Destroy(this.gameObject);
		}
		oldValue = collisionInfo.relativeVelocity.magnitude;
	}
}
