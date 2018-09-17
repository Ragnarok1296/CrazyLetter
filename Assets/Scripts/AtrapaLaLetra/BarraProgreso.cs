using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour {

	public Transform BarraEspera;
	public Text TextProgreso;

    public float time;
    private float aux;

    private void Awake()
    {
        aux = time;
    }

    // Update is called once per frame
    void Update () {

        if(aux <= time)
            aux -= Time.deltaTime;

        BarraEspera.GetComponent<Image>().fillAmount = aux / time;
        TextProgreso.text = aux.ToString("f0");

        if (aux <= 0)
        {
            
            aux = time;
        }

    }
}
