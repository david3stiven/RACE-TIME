using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTiempo : MonoBehaviour {

    public GameObject Numero3;
    public GameObject Numero2;
    public GameObject Numero1;
    public GameObject spriteGO;

   public  float DescNumeros = 0;

    public AudioSource cuenta3;
    public AudioSource cuenta2;
    public AudioSource cuenta1;
    public AudioSource audioGO;

    public ControladorCoche ScritpContoladorCoche;
    public PopInicio scriptPopInicio;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (scriptPopInicio.EmpezarCuentaRegresiva == true)
        {
            DescNumeros += 1 * Time.deltaTime;

            if (DescNumeros >= 5)
            {
                return;
            }
        }

        switch ((int)DescNumeros)
        {


            case 0:
                cuentatres();
                break;
            case 1:
                cuentados();
                break;
            case 2:
                cuentauno();
                break;
            case 3:
                GO();
                break;
            default:
                Numero1.SetActive(false);
                Numero2.SetActive(false);
                Numero3.SetActive(false);
                spriteGO.SetActive(false);
                break;
        }



    }

    void cuentatres()
    {
        Numero3.SetActive(true);
        
    }
    void cuentados()
    {
        
        Numero2.SetActive(true);
        Numero3.SetActive(false);
       
    }
    void cuentauno()
    {
        Numero1.SetActive(true);
        Numero2.SetActive(false);
        Numero3.SetActive(false);
        
    }
    void GO()
    {
        spriteGO.SetActive(true);
        Numero1.SetActive(false);
        ScritpContoladorCoche.TerminoTiempo = true;
    }

    

}
