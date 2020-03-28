using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {


	private Rigidbody2D rb;
	private Vector2 direction = Vector2.one;
	public float speed = 6f;
	
	private void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate () {

		direction.x = Input.GetAxisRaw ("Horizontal");
		direction.y = Input.GetAxisRaw ("Vertical");

		rb.velocity = direction * speed;
	
	}

	public Vector2 position(){
		return rb.position;
	}
}