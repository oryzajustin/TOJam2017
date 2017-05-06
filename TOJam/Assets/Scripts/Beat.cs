using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour {

	private Rigidbody2D rbdy;
    public Collider2D beat_Collider;

    private float speed;
    private int bpm;

    private Vector2 loc;
    private Quaternion rot;

    // Use this for initialization
    void Start () {
		rbdy = GetComponent<Rigidbody2D> ();
        beat_Collider = GetComponent<Collider2D>();

        bpm = 130;
        speed = bpm / 30f;

        loc = new Vector2(10.5f, -3.35f);
        rot = new Quaternion(0, 0, 0, 0);

        InvokeRepeating("Instantiate", 0.5f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
            
		float hor = 0 - speed;
        float vert = 0;
		Vector2 beat = new Vector2 (hor,vert);
        rbdy.velocity = beat * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void Instantiate()
    {
        Instantiate(gameObject, loc, rot);
    }
}
