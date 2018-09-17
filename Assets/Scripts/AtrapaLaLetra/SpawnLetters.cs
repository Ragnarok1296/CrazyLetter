using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLetters : MonoBehaviour {

    public float maxRadius = 1.0f;
    public float interval = 5.0f;
    public GameObject objectToSpawn = null;
    private Transform origin = null;
    private SpriteRenderer sprite;
    private int anterior;
    private int aleatorio;
    public Text letraAleatoria;

    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;
    public Sprite E;
    public Sprite F;
    public Sprite G;
    public Sprite H;
    public Sprite I;
    public Sprite J;
    public Sprite K;
    public Sprite L;
    public Sprite M;
    public Sprite N;
    public Sprite O;
    public Sprite P;
    public Sprite Q;
    public Sprite R;
    public Sprite S;
    public Sprite T;
    public Sprite U;
    public Sprite V;
    public Sprite W;
    public Sprite X;
    public Sprite Y;
    public Sprite Z;

    private void Awake()
    {
        sprite = objectToSpawn.GetComponentInChildren<SpriteRenderer>();
        origin = GameObject.FindGameObjectWithTag ("Techo").GetComponent<Transform>();
        anterior = 27;
        generarLetras();
    }

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", 0.0f, interval);

    }

    void Spawn() {

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
            aleatorio = Random.Range(1, 27);

        } while (aleatorio == anterior);

        anterior = aleatorio;

        switch (aleatorio)
        {
            case 1:
                sprite.sprite = A;
                break;

            case 2:
                sprite.sprite = B;
                break;

            case 3:
                sprite.sprite = C;
                break;

            case 4:
                sprite.sprite = D;
                break;

            case 5:
                sprite.sprite = E;
                break;

            case 6:
                sprite.sprite = F;
                break;

            case 7:
                sprite.sprite = G;
                break;

            case 8:
                sprite.sprite = H;
                break;

            case 9:
                sprite.sprite = I;
                break;

            case 10:
                sprite.sprite = J;
                break;

            case 11:
                sprite.sprite = K;
                break;

            case 12:
                sprite.sprite = L;
                break;

            case 13:
                sprite.sprite = M;
                break;

            case 14:
                sprite.sprite = N;
                break;

            case 15:
                sprite.sprite = O;
                break;

            case 16:
                sprite.sprite = P;
                break;

            case 17:
                sprite.sprite = Q;
                break;

            case 18:
                sprite.sprite = R;
                break;

            case 19:
                sprite.sprite = S;
                break;

            case 20:
                sprite.sprite = T;
                break;

            case 21:
                sprite.sprite = U;
                break;

            case 22:
                sprite.sprite = V;
                break;

            case 23:
                sprite.sprite = W;
                break;

            case 24:
                sprite.sprite = X;
                break;

            case 25:
                sprite.sprite = Y;
                break;

            case 26:
                sprite.sprite = Z;
                break;

        }

    }

    void generarLetraSeleccionada()
    {
        int numAleatorio = Random.Range(1, 3);

        if(numAleatorio == 2)
        {
            switch (letraAleatoria.text)
            {

                case "A":
                    sprite.sprite = A;
                    break;

                case "B":
                    sprite.sprite = B;
                    break;

                case "C":
                    sprite.sprite = C;
                    break;

                case "D":
                    sprite.sprite = D;
                    break;

                case "E":
                    sprite.sprite = E;
                    break;

                case "F":
                    sprite.sprite = F;
                    break;

                case "G":
                    sprite.sprite = G;
                    break;

                case "H":
                    sprite.sprite = H;
                    break;

                case "I":
                    sprite.sprite = I;
                    break;

                case "J":
                    sprite.sprite = J;
                    break;

                case "K":
                    sprite.sprite = K;
                    break;

                case "L":
                    sprite.sprite = L;
                    break;

                case "M":
                    sprite.sprite = M;
                    break;

                case "N":
                    sprite.sprite = N;
                    break;

                case "O":
                    sprite.sprite = O;
                    break;

                case "P":
                    sprite.sprite = P;
                    break;

                case "Q":
                    sprite.sprite = Q;
                    break;

                case "R":
                    sprite.sprite = R;
                    break;

                case "S":
                    sprite.sprite = S;
                    break;

                case "T":
                    sprite.sprite = T;
                    break;

                case "U":
                    sprite.sprite = U;
                    break;

                case "V":
                    sprite.sprite = V;
                    break;

                case "W":
                    sprite.sprite = W;
                    break;

                case "X":
                    sprite.sprite = X;
                    break;

                case "Y":
                    sprite.sprite = Y;
                    break;

                case "Z":
                    sprite.sprite = Z;
                    break;

            }

        }

    }

	// Update is called once per frame
	void Update () {

        



    }
}
