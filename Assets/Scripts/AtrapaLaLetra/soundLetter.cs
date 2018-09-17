using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundLetter : MonoBehaviour {

    public AudioSource sonidoDeLetra = null;
    

    private void Awake()
    {
        
    }


    public void reproducir()
    {
       
        sonidoDeLetra.Play();

    }


}
