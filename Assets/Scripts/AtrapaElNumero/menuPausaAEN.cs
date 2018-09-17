using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausaAEN : MonoBehaviour {

    public string mainMenuSceneName = null;
    public Font pauseMenuFont = null;
    private bool pauseEnabled = false;
    public GUIContent play = null;
    public GUIContent reiniciar = null;
    public GUIContent salir = null;

    // Use this for initialization
    void Start()
    {

        pauseEnabled = false;
        Time.timeScale = 1;
        AudioListener.volume = 1;
        Cursor.visible = false;

    }

    public void pausar()
    {

        if (pauseEnabled)
        {
            pauseEnabled = false;
            Time.timeScale = 1;
            AudioListener.volume = 1;
            Cursor.visible = false;
        }

        else if (!pauseEnabled)
        {
            pauseEnabled = true;
            AudioListener.volume = 0;
            Time.timeScale = 0;
            Cursor.visible = true;
        }


    }

    public void OnGUI()
    {
        GUI.skin.box.font = pauseMenuFont;
        GUI.skin.button.font = pauseMenuFont;

        if (pauseEnabled == true)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 200, 500, 100), play))
            {
                pauseEnabled = false;
                Time.timeScale = 1;
                AudioListener.volume = 1;
                Cursor.visible = false;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 50, 500, 100), reiniciar))
            {
                SceneManager.LoadScene("scene013(AtrapaElNumero)");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 + 100, 500, 100), salir))
            {
                SceneManager.LoadScene("scene003(MenuMinijuegos)");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
