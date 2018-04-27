using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEscenario : MonoBehaviour {

    public GameObject MotorCarretera;
    public GameObject[] piezasescenario;
    public int numCalle;

	public   List <GameObject> listGameObjec = new List<GameObject> ();
    public ControladorCoche scriptControladorCoche;
    
   
	 

    void CrearEscenario()
    {
      int  SelecEscenario = Random.Range(0, 4);
     
	

		GameObject calle = (GameObject)Instantiate (piezasescenario [SelecEscenario], new Vector3 (-0.4f, 28.8f, 0), Quaternion.identity);

		calle.transform.position = new Vector3 (-0.34f, 28.8f, 0);
        numCalle++;
        calle.name = "calle" + numCalle;

        calle.transform.parent = MotorCarretera.transform;

		listGameObjec.Add (calle);
	
		if (listGameObjec.Count > 2) {
			Destroy (listGameObjec [listGameObjec.Count - 3], 5f);
			
			listGameObjec.RemoveAt (listGameObjec.Count - 3);
		}
	
        
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "GameController"  )
        {
            CrearEscenario();
         
        }
    }
    
}
