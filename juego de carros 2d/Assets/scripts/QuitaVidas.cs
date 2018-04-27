using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitaVidas : MonoBehaviour {

    public GameObject SpriteVida1;
    public GameObject SpriteVida2;
    public GameObject SpriteVida3;

    public bool Vida1Perdida;
    public bool Vida2Perdida;
    public bool Vida3Perdida;

    public bool VidaPerdida1;
    public bool VidaPerdida2;
    public bool VidaPerdida3;

    public ControladorCoche scriptControladorCoche;
    public AudioSource AudioQuitaVidas;
    public Graphic imagenQuitaVida;

	float maxtime = 1;
	float time;
    private void Start()
    {
        imagenQuitaVida.CrossFadeAlpha(0, 0, false);
    }

	public void Update()
	{

		time += 1*Time.deltaTime;

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

       
		if (collision.gameObject.tag == "coche" && time>maxtime)
        {
			time = 0;
            scriptControladorCoche.VidaCarro -= 1;

            switch (scriptControladorCoche.VidaCarro)
            {
                case 2:
                    AudioQuitaVidas.Play();
                    
                    PerdioTerceraVida();
                    Destroy(this.gameObject, 0.2f);
                    break;

                case 1:
                    AudioQuitaVidas.Play();
                
                    PerdioSegundaVida();
                    Destroy(this.gameObject, 0.2f);
                    break;

                case 0:
                    AudioQuitaVidas.Play();
                    
                    PerdioPrimerVida();
                    Destroy(this.gameObject, 0.2f);
                    break;


            }
        }

    }

    




    public void PerdioPrimerVida()
    {
        Vida1Perdida = true;
        SpriteVida1.SetActive(false);
        
        imagenQuitaVida.CrossFadeAlpha(1, 0f, false);
        StartCoroutine(AlphaQuitaVidas());
    }

    public void PerdioSegundaVida()
    {
        Vida2Perdida = true;
        SpriteVida2.SetActive(false);
       
        imagenQuitaVida.CrossFadeAlpha(1, 0f, false);
        StartCoroutine(AlphaQuitaVidas());
    }


    public void PerdioTerceraVida()
    {
        Vida3Perdida = true;
        SpriteVida3.SetActive(false);
      
        imagenQuitaVida.CrossFadeAlpha(1, 0f, false);
        StartCoroutine(AlphaQuitaVidas());
    }

    public IEnumerator AlphaQuitaVidas()
    {
        imagenQuitaVida.CrossFadeAlpha(0, 5f, false);
        yield return new WaitForSeconds(1);
    }
}
