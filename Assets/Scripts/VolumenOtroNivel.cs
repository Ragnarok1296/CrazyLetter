using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumenOtroNivel : MonoBehaviour {

    public AudioSource sonido = null;
    public static float posicion = 0;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        AudioListener.volume = 1;
        sonido.time = posicion;
        sonido.volume = Volumen.volumenEstatico;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        posicion = sonido.time;
    }
}
