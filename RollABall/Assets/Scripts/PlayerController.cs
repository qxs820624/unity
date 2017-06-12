using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text countText;
	public Text winText;

	private int count;

	void Start ()
	{
		count = 0;
		countText = GameObject.Find ("Canvas/Text").GetComponent<Text> ();
		winText = GameObject.Find ("Canvas/Text").GetComponent<Text> ();
		winText.text = "";
		ShowCount ();
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 moveMent = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent <Rigidbody> ().AddForce (moveMent * speed * Time.deltaTime);
	}

	void OnTriggerEnter (Collider obj)
	{
		if (obj.gameObject.tag == "PickUp") {
			obj.gameObject.SetActive (false);
			count = count + 1;
			ShowCount ();
			if (count >= 12) {
				winText.text = "You Win!";
			}
		}
		// Destroy (obj.gameObject);
	}

	void ShowCount ()
	{
		countText.text = "Count: " + count.ToString ();
	}
}
