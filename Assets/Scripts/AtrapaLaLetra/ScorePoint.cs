﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour {

    public int scorePoint = 1;
    public GameObject personaje = null;
    public GameObject piso = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sprite = gameObject.GetComponentInChildren<SpriteRenderer>();

        if (personaje.tag == collision.tag)
        {
            if (GameController.letraAux.text == sprite.sprite.name.ToString())
            {

                GameController.score += scorePoint;
            }
            Destroy(gameObject);
        }
        if(piso.tag == collision.tag)
        {
            if (GameController.letraAux.text == sprite.sprite.name.ToString())
            {
                GameController.strike += scorePoint;
                Debug.Log("strike" + GameController.strike);
            }
            Destroy(gameObject);
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
