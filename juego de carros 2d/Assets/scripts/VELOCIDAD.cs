using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VELOCIDAD : MonoBehaviour {

    public ControladorCoche ScriptControlCoche;
    public Rigidbody2D VELOCITY;
    public  float VelocidadCarretera = -13f;
	// Use this for initial ization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (ScriptControlCoche.TerminoTiempo == true)
        {
            transform.Translate(new Vector3(0, VelocidadCarretera * Time.deltaTime, 0));
        }
	}

    public void VelocidadArcen()
    {
        VelocidadCarretera = -8f ;
    }
    public void VelocidadToqueCarro()
    {
        VelocidadCarretera = -8f ;
    }

}
