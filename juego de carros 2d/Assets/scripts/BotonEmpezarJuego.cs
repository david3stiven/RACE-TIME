using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonEmpezarJuego : MonoBehaviour {


    public void EmpezarJuego()
    {
		SceneManager.LoadSceneAsync(2);
    } 
	
}
