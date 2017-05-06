using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Bar : MonoBehaviour {

    public Collider2D bar_Collider;

	// Use this for initialization
	void Start () {
        bar_Collider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
    }

}
