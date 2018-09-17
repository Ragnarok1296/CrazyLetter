using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generarLetra : MonoBehaviour {

    public Text txtLetra = null;

    public float time = 10;
    private float aux;
    private int anterior;
    private int aleatorio;

    private void Awake()
    {
        aux = time;
        anterior = 27;
        generarLetraAleatoria();
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        aux -= Time.deltaTime;
                
        if(aux <= 0)
        {
            generarLetraAleatoria();
            aux = time;
        }
		
	}

    void generarLetraAleatoria()
    {
        do
        {
            aleatorio = Random.Range(1, 27);

        } while (aleatorio == anterior);

        anterior = aleatorio;

        switch (aleatorio)
        {
            case 1:
                txtLetra.text = "A";
                break;

            case 2:
                txtLetra.text = "B";
                break;

            case 3:
                txtLetra.text = "C";
                break;

            case 4:
                txtLetra.text = "D";
                break;

            case 5:
                txtLetra.text = "E";
                break;

            case 6:
                txtLetra.text = "F";
                break;

            case 7:
                txtLetra.text = "G";
                break;

            case 8:
                txtLetra.text = "H";
                break;

            case 9:
                txtLetra.text = "I";
                break;

            case 10:
                txtLetra.text = "J";
                break;

            case 11:
                txtLetra.text = "K";
                break;

            case 12:
                txtLetra.text = "L";
                break;

            case 13:
                txtLetra.text = "M";
                break;

            case 14:
                txtLetra.text = "N";
                break;

            case 15:
                txtLetra.text = "O";
                break;

            case 16:
                txtLetra.text = "P";
                break;

            case 17:
                txtLetra.text = "Q";
                break;

            case 18:
                txtLetra.text = "R";
                break;

            case 19:
                txtLetra.text = "S";
                break;

            case 20:
                txtLetra.text = "T";
                break;

            case 21:
                txtLetra.text = "U";
                break;

            case 22:
                txtLetra.text = "V";
                break;

            case 23:
                txtLetra.text = "W";
                break;

            case 24:
                txtLetra.text = "X";
                break;

            case 25:
                txtLetra.text = "Y";
                break;

            case 26:
                txtLetra.text = "Z";
                break;

            default:
                txtLetra.text = ".";
                break;
        }

    }


}
