using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    private Vector3 _offset;

    void Start()
    {
        _offset = - Target.position + transform.position;
    }
	void Update ()
	{
	    transform.position = Target.position + _offset;
	}
}
