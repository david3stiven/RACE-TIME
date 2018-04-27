using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logoP4 : MonoBehaviour {

    public Graphic logo;
    float tiempoDeCarga;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tiempoDeCarga += 1 * Time.deltaTime;

        if (tiempoDeCarga >= 9)
        {
            SceneManager.LoadScene(1);
        }
	}
}
