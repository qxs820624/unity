using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float RotateAngleX;
	public float RotateAngleY;
	public float RotateAngleZ;

	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (RotateAngleX, RotateAngleY, RotateAngleZ) * Time.deltaTime);
	}
}
