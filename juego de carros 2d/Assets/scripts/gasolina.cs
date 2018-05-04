using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gasolina : MonoBehaviour {
	[SerializeField]
	public Slider sliderGasolina;
	[SerializeField]
	ControladorCoche scontroladorCoche;



	// Use this for initialization
	void Start () {
		sliderGasolina = GameObject.FindGameObjectWithTag("ui").GetComponent<Slider> ();
		sliderGasolina.value = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (scontroladorCoche.TerminoJuego == false) {
			
			sliderGasolina.value -= 0.05f * Time.deltaTime;

		} 



}



}