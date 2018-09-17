using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTipoDeControl : MonoBehaviour {

    public GameObject checkBoton = null;
    public GameObject checkGiroscopio = null;

    // Use this for initialization
    void Start () {

        if (tipoDeControl.tipoControl == "botones")
            boton();
        else if (tipoDeControl.tipoControl == "giroscopio")
            giroscopio();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void boton()
    {
        tipoDeControl.tipoControl = "botones";
        checkBoton.gameObject.SetActive(true);
        checkGiroscopio.gameObject.SetActive(false);
    }

    public void giroscopio()
    {

        tipoDeControl.tipoControl = "giroscopio";
        checkBoton.gameObject.SetActive(false);
        checkGiroscopio.gameObject.SetActive(true);


    }

}
