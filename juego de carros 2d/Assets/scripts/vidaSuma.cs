using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vidaSuma : MonoBehaviour {

   public   ControladorCoche scriptControladorCoche;
    public AudioSource AudioCogioItem;

    public GameObject spriteDaVida2;
    public GameObject spriteDaVida3;

    public Graphic ImagenDaVida;
   
	gasolina sgasolina;

    private void Start()
    {
        ImagenDaVida.CrossFadeAlpha(0, 0, false);
		sgasolina = GameObject.FindGameObjectWithTag ("coche").GetComponent<gasolina> ();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "coche" && scriptControladorCoche.VidaCarro < 3)
        {

            AudioCogioItem.Play();
            scriptControladorCoche.VidaCarro += 1;
			sgasolina.sliderGasolina.value += 0.40f;
            switch (scriptControladorCoche.VidaCarro)
            {

                case 2:
                    PerdioSegundaVida();
                    break;

                case 3:
                    perdioTercerVida();
                    break;
            }

        }
    }

    void PerdioSegundaVida()
    {
        ImagenDaVida.CrossFadeAlpha(1, 0f, false);
        spriteDaVida2.SetActive(true);
       StartCoroutine( AlphaImagenDaVida());
       // Destroy(this.gameObject, 1f);
    }

    void perdioTercerVida()
    {
        ImagenDaVida.CrossFadeAlpha(1, 0f, false);
        spriteDaVida3.SetActive(true);
     StartCoroutine(AlphaImagenDaVida());
      //  Destroy(this.gameObject, 2f);
    }


    IEnumerator AlphaImagenDaVida()
    {

        ImagenDaVida.CrossFadeAlpha(0, 0.5f, false);
        yield return new WaitForSeconds(1);
       
            
            
        
    }

    }

