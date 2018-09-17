using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarImagen : MonoBehaviour {
    
    public Image imagenACambiar = null;
    public Sprite imagen1;
    public Sprite imagen2;
    public Sprite imagen3;
    public Sprite imagen4;
    public Sprite imagen5;
    public Sprite imagen6;
    public Sprite imagen7;
    public Sprite imagen8;
    public Sprite imagen9;
    public Sprite imagen10;
    public Text pagina;

    private int contador = 0;

    public void Anterior()
    {
        if(contador >= 1)
        {
            contador--;
            if (contador + 1 < 10)
                pagina.text = "0" + (contador + 1) + "/10";
            else if (contador + 1 >= 10)
                pagina.text = (contador + 1) + "/10";
            if (contador == 0)
                imagenACambiar.sprite = imagen1;
            if (contador == 1)
                imagenACambiar.sprite = imagen2;
            if (contador == 2)
                imagenACambiar.sprite = imagen3;
            if (contador == 3)
                imagenACambiar.sprite = imagen4;
            if (contador == 4)
                imagenACambiar.sprite = imagen5;
            if (contador == 5)
                imagenACambiar.sprite = imagen6;
            if (contador == 6)
                imagenACambiar.sprite = imagen7;
            if (contador == 7)
                imagenACambiar.sprite = imagen8;
            if (contador == 8)
                imagenACambiar.sprite = imagen9;
            if (contador == 9)
                imagenACambiar.sprite = imagen10;
        }
    }

    public void Siguiente() {
        if(contador <= 8)
        {
            contador++;
            if (contador+1 < 10)
                pagina.text = "0" + (contador + 1) + "/10";
            else if (contador+1 >= 10)
                pagina.text = (contador + 1) + "/10";
            if (contador == 1)
                imagenACambiar.sprite = imagen2;
            if (contador == 2)
                imagenACambiar.sprite = imagen3;
            if (contador == 3)
                imagenACambiar.sprite = imagen4;
            if (contador == 4)
                imagenACambiar.sprite = imagen5;
            if (contador == 5)
                imagenACambiar.sprite = imagen6;
            if (contador == 6)
                imagenACambiar.sprite = imagen7;
            if (contador == 7)
                imagenACambiar.sprite = imagen8;
            if (contador == 8)
                imagenACambiar.sprite = imagen9;
            if (contador == 9)
                imagenACambiar.sprite = imagen10;
        }
    }
}
