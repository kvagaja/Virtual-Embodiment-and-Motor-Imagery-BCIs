using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Assets.LSL4Unity.Scripts.Examples;

public class GetStimulus : MonoBehaviour
{

	//public Image cross, leftarrow, rightarrow;
	public GameObject cross, leftarrow, rightarrow;

	public GameObject EndofSessionPanel;

	//public GameObject lslobject;

	// Use this for initialization
	void Start()
	{

		//cross.enabled = false;
		//leftarrow.enabled = false;
		//rightarrow.enabled = false;
		cross.SetActive(false);
		leftarrow.SetActive(false);
		rightarrow.SetActive(false);
		EndofSessionPanel.SetActive(false);

		Movehands.RH = false;
		Movehands.LH = false;

		Cursor.visible = false;

	}

	// Update is called once per frame
	void Update()
	{


		//quit 
		if (Input.GetKey("escape"))
		{
			Debug.Log("Quit!");
			Application.Quit();
		}

		//reload scene
		//		if (Input.GetKey(KeyCode.R))
		//		{
		//			ReloadScene();
		//		}


		getStim();


		if (LSLMIMarkers.getLSLsample == 1010 || LSLMIMarkers.getLSLsample == 11) //32770 experiment stop
			EndofSessionPanel.SetActive(true); //pop window

		//Debug.Log ("End of Session!");
		if (LSLMIMarkers.getLSLsample == 33282 || LSLMIMarkers.getLSLsample == 2) //32770 experiment start
			EndofSessionPanel.SetActive(false); //pop window

	}


	void getStim()
	{
		int stim = LSLMIMarkers.getLSLsample;

		switch (stim)
		{
			case 800:
			case 10: //hide cross
				cross.SetActive(false);
				leftarrow.SetActive(false);
				rightarrow.SetActive(false);
				Movehands.RH = false;
				Movehands.LH = false;
				break;
			case 33282:
			case 6://beep
				cross.SetActive(true);
				leftarrow.SetActive(false);
				rightarrow.SetActive(false);
				Movehands.RH = false;
				Movehands.LH = false;
				break;
			case 786:
			case 5:  // show cross
				cross.SetActive(true);
				leftarrow.SetActive(false);
				rightarrow.SetActive(false);
				Movehands.RH = false;
				Movehands.LH = false;
				break;
			case 770:
			case 8:// right arrow
				cross.SetActive(true);
				leftarrow.SetActive(false);
				rightarrow.SetActive(true);
				Movehands.RH = true;
				Movehands.LH = false;
				break;
			case 769:
			case 7:// left arrow
				cross.SetActive(true);
				leftarrow.SetActive(true);
				rightarrow.SetActive(false);
				Movehands.RH = false;
				Movehands.LH = true;
				break;
			case 781:
			case 9:// hide arrow
				cross.SetActive(true);
				leftarrow.SetActive(false);
				rightarrow.SetActive(false);
				break;
			default:
				cross.SetActive(false);
				leftarrow.SetActive(false);
				rightarrow.SetActive(false);
				//Movehands.RH = false;
				//Movehands.LH = false;
				break;
		}
	}


	//	public void ReloadScene(){
	//		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	//		Instantiate(lslobject, new Vector3(0, 0, 0), Quaternion.identity);
	//		Debug.Log ("RELOAD Scene!");
	//	}


}