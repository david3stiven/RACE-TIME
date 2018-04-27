using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class comprarcoche : MonoBehaviour {

	public void BotonComprarCoche()
	{
		SceneManager.LoadSceneAsync(3);
	}
}
