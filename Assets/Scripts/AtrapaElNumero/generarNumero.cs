using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generarNumero : MonoBehaviour {

    public Text txtLetra = null;

    public float time = 10;
    private float aux;
    private int anterior;
    private int aleatorio;

    private void Awake()
    {
        aux = time;
        anterior = 5;
        generarLetraAleatoria();
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        aux -= Time.deltaTime;

        if (aux <= 0)
        {
            generarLetraAleatoria();
            aux = time;
        }

    }

    void generarLetraAleatoria()
    {
        do
        {
            aleatorio = Random.Range(1, 11);

        } while (aleatorio == anterior);

        anterior = aleatorio;

        switch (aleatorio)
        {
            case 1:
                txtLetra.text = "0";
                break;

            case 2:
                txtLetra.text = "1";
                break;

            case 3:
                txtLetra.text = "2";
                break;

            case 4:
                txtLetra.text = "3";
                break;

            case 5:
                txtLetra.text = "4";
                break;

            case 6:
                txtLetra.text = "5";
                break;

            case 7:
                txtLetra.text = "6";
                break;

            case 8:
                txtLetra.text = "7";
                break;

            case 9:
                txtLetra.text = "8";
                break;

            case 10:
                txtLetra.text = "9";
                break;

        }

    }


}
