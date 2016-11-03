using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;

	void FixedUpdate ()
	{
		Vector3 newPosition = target.position;
		newPosition.z = -10;

		transform.position = newPosition;
	}

}
