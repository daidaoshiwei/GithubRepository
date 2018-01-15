using UnityEngine;
using System.Collections;

// Note: this is not an editor script.
public class WaypointPath : MonoBehaviour {
	public Transform[] wayPointArray = new Transform[1];

	void awek()
	{
		wayPointArray [1] = GameObject.Find ("Cube").transform;
	}

}