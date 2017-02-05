using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb2D;
    SpriteRenderer spR;

    public float jumpPower = 10;

	// Use this for initialization
	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
        spR = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") * 12;
        //float y = Input.GetAxis("Vertical");

        rb2D.velocity = new Vector3(x, rb2D.velocity.y, 0);
        if (x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb2D.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
        }

    }
}
