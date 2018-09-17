using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// Implement your game events in this script
public class Events : MonoBehaviour
{
		private WritingHandler writingHandler;

		void Start ()
		{
				//Setting up the writingHandler reference
				GameObject letters = HierrachyManager.FindActiveGameObjectWithName ("Letters");
				if (letters != null)
						writingHandler = letters.GetComponent<WritingHandler> ();
		}

		//Load the next letter
		public void LoadTheNextLetter (object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.LoadNextLetter ();
		}

		//Load the previous letter
		public void LoadThePreviousLetter (object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.LoadPreviousLetter ();

		}

		//Load the current letter
		public void LoadLetter (Object ob)
		{
				if (ob == null) {
						return;
				}
				WritingHandler.currentLetterIndex = int.Parse (ob.name.Split ('-') [1]);
                SceneManager.LoadScene("scene009(AlphabetWriting)");
		}

        public void LoadNumber(Object ob)
        {
            Debug.Log("Todo bien");
            if (ob == null)
            {
                return;
            }
            WritingHandler.currentLetterIndex = int.Parse(ob.name.Split('-')[1]);
            SceneManager.LoadScene("scene011(NumericWriting)");
        }

    //Erase the current letter
    public void EraseLetter (Object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.RefreshProcess ();

		}

    public void EraseNumber(Object ob)
    {
        if (writingHandler == null)
        {
            return;
        }
        writingHandler.eraseNumber();
    }


    //Load alphabet menu
    public void LoadAlphabetMenu(Object ob){
        

        SceneManager.LoadScene("scene008(Letras)");
        
    }

    public void LoadNumericMenu(Object ob)
    {


        SceneManager.LoadScene("scene010(Numeros)");

    }

}