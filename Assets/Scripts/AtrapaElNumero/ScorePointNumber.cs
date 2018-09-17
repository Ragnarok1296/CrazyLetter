using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePointNumber : MonoBehaviour {

    public int scorePoint = 1;
    public GameObject personaje = null;
    public GameObject piso = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sprite = gameObject.GetComponentInChildren<SpriteRenderer>();
        Debug.Log(gameControllerAEN.letraAuxAEN.text + "," + sprite.sprite.name.ToString());
        if (personaje.tag == collision.tag)
        {
            Debug.Log("TODO BIEN");
            Debug.Log(gameControllerAEN.letraAuxAEN.text + "," + sprite.sprite.name.ToString());
            if (gameControllerAEN.letraAuxAEN.text == sprite.sprite.name.ToString())
            {
                Debug.Log("TODO BIEN 2");
                gameControllerAEN.scoreAEN += scorePoint;
            }
            Destroy(gameObject);
        }
        if (piso.tag == collision.tag)
        {
            if (gameControllerAEN.letraAuxAEN.text == sprite.sprite.name.ToString())
            {
                gameControllerAEN.strikeAEN += scorePoint;
                Debug.Log("strike" + gameControllerAEN.strikeAEN);
            }
            Destroy(gameObject);
        }

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
