using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

	public GameObject player;
	private Vector3 offset;
	// called when loaded
	void Awake(){
		// print just use in MonoBehaviour
		print ("Awake");
	}
	// Use this for initialization
	// called once before the first update
	void Start ()
	{
		print ("Start");
		offset = transform.position;
	}
	// called when enabled
	void OnEnable(){
		print ("OnEnable");
	}
	// Update is called once per frame
	void Update(){
		print ("Update");
		// check if w pressed in this frame, should check every frame
		bool bw = Input.GetKeyDown(KeyCode.W);
		if (b){
			print("Move front");
		}else{
			Debug.Log("Move back");
		}
		if (Input.GetKeyUp(KeyCode.Alpha1){
			print ("key 1 up");
		} else if (Input.GetKey(KeyCode.A){
			print("press A continous")
		}
		// 鼠标按键按下
		if (Input.GetMouseButtonDown(0)){
			print ("press left mouse ");
		}else if (Input.GetMouseButtonDown(1)){
			print ("press right mouse ");
		}else if (Input.GetMouseButtonDown(2)){
			print ("press middle mouse ");
		}
		// 鼠标按键弹起
		if (Input.GetMouseButtonUp(0)){
			print ("press left mouse ");
		}else if (Input.GetMouseButtonUp(1)){
			print ("press right mouse ");
		}else if (Input.GetMouseButtonUp(2)){
			print ("press middle mouse ");
		}
		// 持续按下
		if (Input.GetMouseButton(0)){
			print ("press left mouse ");
		}else if (Input.GetMouseButton(1)){
			print ("press right mouse ");
		}else if (Input.GetMouseButton(2)){
			print ("press middle mouse ");
		}
		
	}
	
	// LateUpdate is called once per frame
	void LateUpdate ()
	{
		print ("LateUpdate");
		transform.position = player.transform.position + offset;
	}
	
	// FixedUpdate is called at a certern frequence, not even effected by frame frequence
	void FixedUpdate(){
		print ("FixedUpdate");
	}
	
	// OnDisable called when disable the script
	void OnDisable(){
		print ("OnDisable");
	}
	
	// OnDestroy called when destroy the game object
	void OnDestroy(){
		print ("OnDestroy");
	}
	
}
