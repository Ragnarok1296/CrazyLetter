using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static int score = 0;
    public string scorePrefix = string.Empty;
    public Text scoreText = null;
    public static int strike = 0;

    public static GameController gameController = null;
    public GameObject personaje = null;
    public GameObject spawner = null;

    public GameObject primerStrike = null;
    public GameObject segundoStrike = null;
    public GameObject tercerStrike = null;

    public static Text letraAux = null;
    public Text letra = null;
    private bool gameOver = false;
    public Font pauseMenuFont = null;
    public GUIContent imgGameOver = null;
    public GUIContent btnReiniciar = null;
    public GUIContent btnRegresar = null;
    public GameObject menuPausa = null;

    public GameObject controlBotones;
    public GameObject controlGiroscopio;
    public string nivelAReiniciar;

    private void Awake()
    {
        gameController = this;
        letraAux = letra;
        strike = 0;
        score = 0;
        personaje.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);

        primerStrike.gameObject.SetActive(false);
        segundoStrike.gameObject.SetActive(false);
        tercerStrike.gameObject.SetActive(false);

        if(tipoDeControl.tipoControl == "botones")
        {
            controlBotones.gameObject.SetActive(true);
            controlGiroscopio.gameObject.SetActive(false);
        }
        else if(tipoDeControl.tipoControl == "giroscopio")
        {

            controlGiroscopio.gameObject.SetActive(true);
            controlBotones.gameObject.SetActive(false);
        }


    }

    void Start () {
        

    }
	
	void Update () {
        if(scoreText != null)
        {
            if (strike == 1)
                primerStrike.gameObject.SetActive(true);

            if (strike == 2)
                segundoStrike.gameObject.SetActive(true);

            if (strike == 3)
            {
                tercerStrike.gameObject.SetActive(true);
                GameOver();
                return;
            }
            
            scoreText.text = scorePrefix + score.ToString();  
        }

		
	}

    public void GameOver()
    {
        gameOver = true;
    }

    private void OnGUI()
    {
        GUI.skin.box.font = pauseMenuFont;
        GUI.skin.button.font = pauseMenuFont;

        if (gameOver)
        {
            GUI.Box(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 280, 500, 350),imgGameOver);
            
            Time.timeScale = 0;
            menuPausa.gameObject.SetActive(false);

            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 +70, 500, 100), btnReiniciar))
            {
                SceneManager.LoadScene(nivelAReiniciar);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 + 170, 500, 100), btnRegresar))
            {
                SceneManager.LoadScene("scene003(MenuMinijuegos)");
            }


        }

    }

    public void reiniciarNivel()
    {
        Awake();

    }

}
