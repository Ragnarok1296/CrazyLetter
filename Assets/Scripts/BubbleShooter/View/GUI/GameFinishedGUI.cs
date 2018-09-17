using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace com.javierquevedo.gui{
	
	public class GameFinishedGUI : MenuGUI {
	
		GameFinishGUIDelegate startNewGameSelectedDelegate;
		public delegate void GameFinishGUIDelegate();
			
		public GameFinishGUIDelegate StartNewGameSelectedDelegate{
			set{
				this.startNewGameSelectedDelegate = value;
			}
		}
		
		public Game game;
		void Start () {
				base.Start();;
			}
			
			// Update is called once per frame
			void Update () {
				base.Update ();
            
                
			
			}
			
			protected override void  OnGUI(){
            /*GUI.Box(new Rect(Screen.width/2 - _menuWidth /2.0f, Screen.height/2 - _menuHeight /2.0f, _menuWidth, _menuHeight), "Bubble Shooter");
            GUI.Label(new Rect(Screen.width/2 - _buttonWidth /2.0f, (Screen.height/2 - _buttonHeight /2.0f) - 14, _buttonWidth, _buttonHeight), 
            "YOU " + (game.state == GameState.Win ? "WON!" : "LOST!"));	
            if (GUI.Button(new Rect(Screen.width/2 - _buttonWidth /2.0f, (Screen.height/2 - _buttonHeight /2.0f) + 15, _buttonWidth, _buttonHeight), "BACK TO MENU")){
                //this.newGameWasSelected();
                SceneManager.LoadScene("scene003(MenuMinijuegos)");
            }*/



            GUI.Box(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 280, 500, 350), SplashScreenController.gameOverMenuGO);

            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 + 70, 500, 100), SplashScreenController.reiniciarMenuGO))
            {
                SceneManager.LoadScene("scene012(BubbleShooter)");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height / 2 + 170, 500, 100), SplashScreenController.salirMenuGO))
            {
                SceneManager.LoadScene("scene003(MenuMinijuegos) ");
            }

        }

        private void newGameWasSelected(){
			if (startNewGameSelectedDelegate != null)
				startNewGameSelectedDelegate();
			}
		}
			


}
