using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	void Update ()
	{
		transform.Rotate(new Vector3(0, 1.0f, 0));	
	}
}
