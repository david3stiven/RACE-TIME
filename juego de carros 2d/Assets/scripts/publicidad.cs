using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
using UnityEngine.UI;
public class publicidad : MonoBehaviour
{
	
	//PUBLICIDAD DE REGALO
	public	ControladorCoche sControladorCoche;
	public Graphic GameOver;
	public GameObject botonQuit;
	public Graphic difuminado;
	public GameObject botonReiniciar;
	public GameObject textPublicidad;
	public Graphic textMetros;
	public GameObject vidas1;
	public GameObject vidas2;
	public GameObject vida3;
	public VELOCIDAD sVelocidad;
	public AudioSource consolaMotor;
	public AudioClip motor;

	public Text textTiempoRevivir;
	public  float TiempoRevivir;

	public gasolina gasolina; 

	void Start()
	{
		Advertisement.Initialize ("1699127", false);
		Advertisement.IsReady ("1699127");	
		TiempoRevivir = 5;
	}
		
	void Update()
	{
		TiempoRevivir -= 1 * Time.deltaTime;
		textTiempoRevivir.text = "" + TiempoRevivir;
		if (TiempoRevivir <= 0 && this.gameObject != null) 
		{
		//	this.gameObject.SetActive (false);
		//	TiempoRevivir = 5;
		}
	}


	public void Publicidad()
	{
		ShowOptions NshowOptions = new ShowOptions ();
		NshowOptions.resultCallback = showResultados;
		Advertisement.Show ("",NshowOptions);

	
	}



	public void showResultados(ShowResult resultados)
	{
		switch (resultados) 
		{
		case ShowResult.Finished:
			GameOver.CrossFadeAlpha (0, 0, false);
			botonQuit.SetActive (false);
			difuminado.CrossFadeAlpha (0, 0, false);
			vidas1.gameObject.SetActive (false);
			vidas2.gameObject.SetActive (false);
			vida3.gameObject.SetActive (true);
			textPublicidad.gameObject.SetActive (false);
			botonReiniciar.gameObject.SetActive (false);
			sControladorCoche.TerminoJuego = false;
			sControladorCoche.TerminoTiempo = false;
			sControladorCoche.VidaCarro += 1;
			textMetros.CrossFadeAlpha (0, 0, false);
			consolaMotor.clip = motor;
			consolaMotor.Play ();
			sControladorCoche.TerminoTiempo = true;
			sVelocidad.VelocidadCarretera = -13;

			gasolina.GetComponent<gasolina> ().sliderGasolina.value = 1;

			Debug.Log ("entro");
			break;
		case ShowResult.Skipped:
			textPublicidad.gameObject.SetActive (true);
			break;

		}
	}
}