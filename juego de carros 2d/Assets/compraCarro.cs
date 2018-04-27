using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class compraCarro : MonoBehaviour {

	public	GameObject Carro;
	public Sprite carroComprado;
	public GameObject EsteScript;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);

		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.GetFloat ("coche", MetrosRecorridos.totalMetrosRecorridos);
		print (MetrosRecorridos.totalMetrosRecorridos + "total metros recorridos");
		if (GameObject.FindGameObjectWithTag("coche")) 
		{
			print ("entro");
			Carro = GameObject.FindGameObjectWithTag ("coche").gameObject;
			Carro.GetComponent<SpriteRenderer> ().sprite = carroComprado; 
		}
	}
}
