using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMinijuegos : MonoBehaviour {

    public void cambiarMinijuegos_Menu()
    {
        SceneManager.LoadScene("scene001(MenuPrincipal)");
    }

    public void cambiarMinijuegos_AtrapaLaLetra()
    {
        SceneManager.LoadScene("scene007(AtrapaLaLetra)");

    }

    public void cambiarMinijuegos_AtrapaElNumero()
    {
        SceneManager.LoadScene("scene013(AtrapaElNumero)");

    }

    public void cambiarMenu_BubbleShooter()
    {
        SceneManager.LoadScene("scene012(BubbleShooter)");
    }

}
