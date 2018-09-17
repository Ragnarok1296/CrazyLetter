using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuJugar : MonoBehaviour {

    public void cambiarJugar_Menu()
    {
        SceneManager.LoadScene("scene001(MenuPrincipal)");
    }

    public void cambiarJugar_Letras()
    {
        SceneManager.LoadScene("scene008(Letras)");
    }

    public void cambiarJugar_Numeros()
    {
        SceneManager.LoadScene("scene010(Numeros)");
    }

    public void cambiarJugar_Jugar()
    {
        SceneManager.LoadScene("scene002(MenuJugar)");
    }

}
