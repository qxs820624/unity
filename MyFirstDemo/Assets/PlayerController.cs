using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 moveMent = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent <Rigidbody> ().AddForce (moveMent * speed * Time.deltaTime);
	}

}
