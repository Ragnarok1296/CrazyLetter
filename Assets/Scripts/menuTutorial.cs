using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuTutorial : MonoBehaviour {

    public void cambiarTutorial_Menu()
    {
        SceneManager.LoadScene("scene001(MenuPrincipal)");
    }
}
