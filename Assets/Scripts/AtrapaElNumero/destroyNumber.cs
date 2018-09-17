using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyNumber : MonoBehaviour {

    public float lifeTime = 2.0f;

    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", lifeTime);
    }


    private void OnTriggerEnter(Collider other)
    {


    }

    void Die()
    {
        Destroy(gameObject);

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
