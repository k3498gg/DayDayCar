using UnityEngine;
using System.Collections;

public class TDCameraController : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.LookAt(target.transform);
	}
}
