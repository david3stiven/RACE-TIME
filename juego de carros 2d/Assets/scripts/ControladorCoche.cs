using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class ControladorCoche : MonoBehaviour {
	
	public	MetrosRecorridos scriptMetrosRecorridos;
    public Animator AniCoche;
    public Rigidbody2D RbCoche;
    public Transform transformCarro;
    public int VidaCarro = 3;
    public float VelCoche;
   
    public bool TerminoTiempo;
    public bool TerminoJuego;
	public bool EntroEnPenalizacion;
    public AudioSource SonidoMotor;
  
    public GameObject Calavera;
    
   public   ControladorTiempo scriptControlTiempo;
   public   VELOCIDAD scriptVelocidad;

	//PENALIZACION

	public	Text textPenalizacion;
	public GameObject[] spriteContador;

    public float angulodegiro;
    // Use this for initialization
    void Start () {
        TerminoTiempo = false;
        TerminoJuego = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
      if  (transformCarro.position.y <= -4.5f)

        {
            pocisionamientoCarro();
        }

        float movimX = Input.GetAxisRaw("Horizontal");
		#if UNITY_ANDROID
		movimX = CrossPlatformInputManager. GetAxisRaw ("Horizontal");
		#endif
        MovimientoXY(movimX);


    }
    // Funcionion Para El Movimiento Del Coche.....................................................................
    void MovimientoXY(float movimX   )
    {
       
        if (movimX > 0 && TerminoTiempo == true  && TerminoJuego == false)
        {
			
            RbCoche.velocity = new Vector3(2f * VelCoche * Time.deltaTime, 0, 0);
       
            
            AniCoche.SetBool("CarroIZQ", true);
        }
        else {
			
            AniCoche.SetBool("CarroIZQ", false);

        }
        if (movimX < 0 && TerminoTiempo == true && TerminoJuego == false)
        {
			
            RbCoche.velocity = new Vector3(-2f * VelCoche * Time.deltaTime, 0, 0);
            AniCoche.SetBool("CarroDCHO", true);
        }
        else
        {
			
            AniCoche.SetBool("CarroDCHO", false);

        }
        if (movimX == 0)
        {
			SonidoMotor.pitch = 1;
            RbCoche.velocity = new Vector3(0f * VelCoche * Time.deltaTime, 0, 0);
        }

		if (movimX != 0) 
		{
			SonidoMotor.pitch = 1.01f;
		}
       
    }

   

    public   void OnTriggerStay2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Arcen")
        {
			

			if (EntroEnPenalizacion) 
			{
				StartCoroutine (penalizacion ());
				EntroEnPenalizacion = false;
			}

            scriptVelocidad.VelocidadArcen();
            SonidoMotor.pitch = 1.2f;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
		EntroEnPenalizacion = true;
		StopCoroutine (penalizacion ());
        scriptVelocidad.VelocidadCarretera = -13f ;
        SonidoMotor.pitch = 1.0f;
    }

	IEnumerator penalizacion()
	{
		textPenalizacion.gameObject.SetActive (true);

		for (int i=0 ; i < spriteContador.Length; i++) 
		{
			

			spriteContador [i].gameObject.SetActive (true);
			yield return new WaitForSeconds (0.3f);
			spriteContador [i].gameObject.SetActive (false);

			if (EntroEnPenalizacion) 
			
			{
				break;
			}
			if (i == 2) 
			{
				VidaCarro -= VidaCarro;
			}

			 
		}
		textPenalizacion.gameObject.SetActive (false);

	}


  void pocisionamientoCarro()
    {
        transformCarro.position = new Vector3(this.transform.position.x, -2.5f, 0);
    }

    


}
