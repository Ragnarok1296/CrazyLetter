using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PreLoaderLevel : MonoBehaviour {

    IEnumerator Start()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("MyBigLevel");
        yield return async;
        Debug.Log("Loading complete");
    }
}
