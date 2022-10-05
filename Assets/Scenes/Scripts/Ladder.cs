using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Ladder : MonoBehaviour

{

	public Transform chController;
	bool inside = false;
	public float speedUpDown = 3.2f;
	public FirstPersonController FPSInput; //skrpyt poruszania siê FPS, jesli inny skrypt by³ uyzty do poruszania to wpisuejmy nazwe tego skryptu
	

	void Start()
	{
		FPSInput = GetComponent<FirstPersonController>();//i tu te¿ nazwê skryptu
		inside = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ladder")
		{
			FPSInput.enabled = false;
			inside = !inside;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Ladder")
		{
			FPSInput.enabled = true;
			inside = !inside;
		}
	}

	void Update()
	{
		if (inside == true && Input.GetKey("w"))
		{
			chController.transform.position += Vector3.up / speedUpDown;
		}

		if (inside == true && Input.GetKey("s"))
		{
			chController.transform.position += Vector3.down / speedUpDown;
		}
	}

}