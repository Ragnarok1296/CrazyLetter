using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationBackground : MonoBehaviour {

    private Renderer _renderer;
    public float scrollingSpeed = .1f;

	// Use this for initialization
	void Start () {
        _renderer = this.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        _renderer.material.mainTextureOffset = _renderer.material.mainTextureOffset + new Vector2(scrollingSpeed * Time.deltaTime, 0);
	}
}
