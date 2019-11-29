using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMarkeMovement : MonoBehaviour {

    float dirX, dirY;
    Rigidbody2D rb;
    [SerializeField]
    private float moveSpeed = 5f;

    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2 (dirX * moveSpeed , dirY *moveSpeed);
	}
}
