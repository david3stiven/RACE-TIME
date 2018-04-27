using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopInicio : MonoBehaviour {

    public Graphic imagen1;
    public Graphic imagen2;
    public Graphic imagen3;
    public bool EmpezarCuentaRegresiva;
	

    public void PrecionarBotton()
    {
        imagen1.CrossFadeAlpha(0, 0.5f, false);
        imagen2.CrossFadeAlpha(0, 0.5f, false);
        imagen3.CrossFadeAlpha(0, 0.5f, false);
        EmpezarCuentaRegresiva = true;
        imagen3.gameObject.SetActive(false);
    }
}
