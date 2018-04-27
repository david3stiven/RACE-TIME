using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {


    public VELOCIDAD scriptVelocidad; 
    public ControladorCoche ScriptControladorCoche;

    AudioSource AudioGameOver;

    public Graphic imagenGameOver1;
    public Graphic imagenGameOver2;
    public Graphic imagenGameOver3;
    public Graphic imagenGameOver4;
    public Graphic imagenGameOver5;
    public Graphic imagenQuit;
    public Graphic imagenTextQuit;
	public GameObject botonRevivir;
	bool activarPublicidad;
public	gasolina sgasolina;

    private void Start()
    {

        AudioGameOver = GetComponent<AudioSource>();
		activarPublicidad = true;
        imagenGameOver1.CrossFadeAlpha(0, 0, false);
        imagenGameOver2.CrossFadeAlpha(0, 0, false);
        imagenGameOver3.CrossFadeAlpha(0, 0, false);
        imagenGameOver4.CrossFadeAlpha(0, 0, false);
        imagenGameOver4.gameObject.SetActive(false);
        imagenGameOver5.CrossFadeAlpha(0, 0, false);
        imagenQuit.CrossFadeAlpha(0, 0, false);
    
        imagenQuit.gameObject.SetActive(false);
		botonRevivir.SetActive (false);
		sgasolina = GameObject.FindGameObjectWithTag ("coche").GetComponent<gasolina> ();
    }

    // Update is called once per frame
    void Update () {
		if (ScriptControladorCoche.VidaCarro <= 0  || sgasolina.sliderGasolina.value <= 0)
			
        {
            ScriptControladorCoche.TerminoJuego = true;
            imagenGameOver4.gameObject.SetActive(true);
            imagenGameOver1.CrossFadeAlpha(1, 1f, true);
            imagenGameOver2.CrossFadeAlpha(1, 1f, false);
            imagenGameOver3.CrossFadeAlpha(1, 1f, false);
            imagenGameOver4.CrossFadeAlpha(1, 1f, false);
            imagenGameOver5.CrossFadeAlpha(1, 1f, false);
            imagenQuit.CrossFadeAlpha(1, 1f, false);
          
            imagenQuit.gameObject.SetActive(true);

		//	if (activarPublicidad) 
	///		{
				botonRevivir.SetActive (true);
				activarPublicidad = false;
	//		}
            TerminoJuego();
            GameObject.FindGameObjectWithTag("motorcarretera").GetComponent<AudioSource>().Stop();
            GameObject.FindGameObjectWithTag("coche").GetComponent<AudioSource>().Stop();
           

        }
    }

    public void TerminoJuego()
    {

      
        scriptVelocidad.VelocidadCarretera = 0f;
    }
    
}
