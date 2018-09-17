using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnNumber : MonoBehaviour {

    public float maxRadius = 1.0f;
    public float interval = 5.0f;
    public GameObject objectToSpawn = null;
    private Transform origin = null;
    private SpriteRenderer sprite;
    private int anterior;
    private int aleatorio;
    public Text letraAleatoria;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;

    private void Awake()
    {
        sprite = objectToSpawn.GetComponentInChildren<SpriteRenderer>();
        origin = GameObject.FindGameObjectWithTag("Techo").GetComponent<Transform>();
        anterior = 5;
        generarLetras();
    }

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, interval);

    }

    void Spawn()
    {

        if (this.gameObject.activeSelf == false)
            objectToSpawn.gameObject.SetActive(false);
        else
            objectToSpawn.gameObject.SetActive(true);

        if (origin == null)
            return;

        Vector3 spawnPosition = origin.position + Random.onUnitSphere * maxRadius;
        spawnPosition = new Vector3(spawnPosition.x, origin.position.y, 1.0f);
        generarLetras();
        generarLetraSeleccionada();
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

    }

    void generarLetras()
    {

        do
        {
            aleatorio = Random.Range(1, 11);

        } while (aleatorio == anterior);

        anterior = aleatorio;

        switch (aleatorio)
        {
            case 1:
                sprite.sprite = zero;
                break;

            case 2:
                sprite.sprite = one;
                break;

            case 3:
                sprite.sprite = two;
                break;

            case 4:
                sprite.sprite = three;
                break;

            case 5:
                sprite.sprite = four;
                break;

            case 6:
                sprite.sprite = five;
                break;

            case 7:
                sprite.sprite = six;
                break;

            case 8:
                sprite.sprite = seven;
                break;

            case 9:
                sprite.sprite = eight;
                break;

            case 10:
                sprite.sprite = nine;
                break;

        }

    }

    void generarLetraSeleccionada()
    {
        int numAleatorio = Random.Range(1, 3);

        if (numAleatorio == 2)
        {
            switch (letraAleatoria.text)
            {

                case "0":
                    sprite.sprite = zero;
                    break;

                case "1":
                    sprite.sprite = one;
                    break;

                case "2":
                    sprite.sprite = two;
                    break;

                case "3":
                    sprite.sprite = three;
                    break;

                case "4":
                    sprite.sprite = four;
                    break;

                case "5":
                    sprite.sprite = five;
                    break;

                case "6":
                    sprite.sprite = six;
                    break;

                case "7":
                    sprite.sprite = seven;
                    break;

                case "8":
                    sprite.sprite = eight;
                    break;

                case "9":
                    sprite.sprite = nine;
                    break;

            }

        }

    }

    // Update is called once per frame
    void Update()
    {





    }

}
