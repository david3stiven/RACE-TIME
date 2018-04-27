using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MetrosRecorridos : MonoBehaviour {

    public ControladorCoche ScriptControladorCoche;

    float TiempoCocheEnMovimiento;
    float VelocidadCoche;
	public static float MetrosRecorridoss;
	public static float totalMetrosRecorridos;
	float maxPuntuacion;
    public Text TextMetros;
	public Text TextMetros1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


        if (ScriptControladorCoche.TerminoTiempo == true && ScriptControladorCoche.TerminoJuego== false)
        {
            VelocidadCoche = 20f;
            TiempoCocheEnMovimiento += 0.5f * Time.deltaTime;

			MetrosRecorridoss = VelocidadCoche * TiempoCocheEnMovimiento;

			TextMetros.text =  "Mts" + ": " + MetrosRecorridoss.ToString("0") ;
			TextMetros1.text =  "Mts" + ": " + MetrosRecorridoss.ToString("0") ;

			totalMetrosRecorridos += MetrosRecorridoss;
			PlayerPrefs.SetFloat ("COCHE", totalMetrosRecorridos);

		}
        }
	

	    
	}

