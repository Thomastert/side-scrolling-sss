using UnityEngine;
using System.Collections;
public class button : MonoBehaviour
{
	void Update () {
		
		if (Input.GetKeyDown("space"))
		{
			Application.LoadLevel("main");	
		}
		
	}
}