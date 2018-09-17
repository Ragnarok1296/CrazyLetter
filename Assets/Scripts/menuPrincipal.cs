using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour {

    public void cambiarMenu_Jugar()
    {
        SceneManager.LoadScene("scene002(MenuJugar)");
    }

    public void cambiarMenu_Minijuegos()
    {
        SceneManager.LoadScene("scene003(MenuMinijuegos)");
    }

    public void cambiarMenu_Tutorial()
    {
        SceneManager.LoadScene("scene004(MenuTutorial)");
    }

    public void cambiarMenu_Ajustes()
    {
        SceneManager.LoadScene("scene005(MenuAjustes)");
    }

    public void cambiarMenu_BubbleShooter()
    {
        SceneManager.LoadScene("scene012(BubbleShooter)");
    }
}
