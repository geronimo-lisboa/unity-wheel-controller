using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform target;

	// Use this for initialization
	void Start () {
		
	}

    private void LateUpdate()
    {
        Vector3 targetPos = target.position;
        Vector3 targetForward = target.forward;
        Vector3 camPos = targetPos + targetForward * (-7.0f) + new Vector3(0, 4.0f, 0);
        this.transform.position = camPos;
        this.transform.LookAt(target);
    }
}
