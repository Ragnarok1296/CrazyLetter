using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour {

    public Slider slider = null;
    public Sprite mute = null;
    public Sprite n1 = null;
    public Sprite n2 = null;
    public Sprite n3 = null;
    public Sprite n4 = null;
    public Image sonido = null;
    public AudioSource audio2;

    public static float volumenEstatico = 1;

	// Use this for initialization
	void Start () {
        slider.value = VolumenOtroNivel.posicion;
        audio2.time = VolumenOtroNivel.posicion;
        volumenEstatico = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        volumenEstatico = slider.value;
        VolumenOtroNivel.posicion = audio2.time;

        if (slider.value == 0.00f)
            sonido.sprite = mute;
        if (slider.value > 0.00f && slider.value <= 0.25f)
            sonido.sprite = n1;
        if (slider.value > 0.25f && slider.value <= 0.50f)
            sonido.sprite = n2;
        if (slider.value > 0.50f && slider.value <= 0.75f)
            sonido.sprite = n3;
        if (slider.value > 0.75f && slider.value <= 1f)
            sonido.sprite = n4;


    }
}
