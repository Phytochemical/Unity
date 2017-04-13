using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour
{
	void Update ()
	{
		Debug.Log("Horizontal Input = " + Input.GetAxis("Horizontal"));
	}
}
