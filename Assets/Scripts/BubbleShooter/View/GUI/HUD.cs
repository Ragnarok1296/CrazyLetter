using UnityEngine;
using System;
using System.Collections;

namespace com.javierquevedo{
	public class HUD : MonoBehaviour {
		
		public Game game;
        private GUIStyle estilo;
        private float _timeOffset;
		void Start () {
			_timeOffset = Time.timeSinceLevelLoad;
            
		}

        private void Awake()
        {
            estilo = new GUIStyle();
            int fuente = Convert.ToInt32(Screen.width / 19.2);
            estilo.fontSize = fuente ;
            Debug.Log(fuente);
            
        }

        void Update () {
		}
		
		void OnGUI(){
            GUI.contentColor = Color.black;

            
            TimeSpan timeSpan = TimeSpan.FromSeconds(Time.timeSinceLevelLoad - _timeOffset);
			string timeText = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
			
			GUI.Label(new Rect(10,10,1000,1000),game.score.ToString(), estilo);
			GUI.Label(new Rect(10,Screen.height/6,1000,1000), timeText, estilo);
			
		}
	}
}
