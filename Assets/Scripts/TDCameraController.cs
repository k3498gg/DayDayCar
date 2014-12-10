using UnityEngine;
using System.Collections;

public class TDCameraController : MonoBehaviour {
    public GameObject target;
    public float delate = 1.0f;
	// Use this for initialization
	void FixedUpdate () {
        transform.RotateAround(target.transform.position, Vector3.up, delate * Time.deltaTime);
       //transform.Translate(transform.forward*Time.deltaTime);
	}
	

}
