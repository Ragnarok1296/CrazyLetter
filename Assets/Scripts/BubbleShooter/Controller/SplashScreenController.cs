using UnityEngine;
using System.Collections;

namespace com.javierquevedo{
	
	public class SplashScreenController : MonoBehaviour {
	
		private GameObject _camera;
		private SplashScreenGUI _gui;
		private const string _bubbleShooterPrefabName = "Prefab/BoobbleShooter/Prefabs/BubbleShooterPrefab";
        public static GUIContent reiniciarMenuGO = null;
        public static GUIContent salirMenuGO = null;
        public static GUIContent gameOverMenuGO = null;
        public GUIContent reiniciar = null;
        public GUIContent salir = null;
        public GUIContent gameOver = null;

        void Start () {
            reiniciarMenuGO = reiniciar;
            salirMenuGO = salir;
            gameOverMenuGO = gameOver;
			_camera = GameObject.Find("Camera");	
			this._gui = _camera.AddComponent<SplashScreenGUI>();
			this._gui.StartGameDelegate = this.startGame;
		}

		
		void startGame(){
			this._gui.StartGameDelegate = null;
			GameObject game = new GameObject("Game");
			game.AddComponent<GameController>();
			Destroy(this._gui);
			Destroy (this.gameObject);
			
		}
	}
}