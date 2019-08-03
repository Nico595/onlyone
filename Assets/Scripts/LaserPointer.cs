using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    public float _laserBeamLength;
    private LineRenderer _linerenderer;
    

    private void Start()
    {
        _linerenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        Vector3 endPosition = transform.position + (transform.up * _laserBeamLength);
        _linerenderer.SetPositions(new Vector3[] { transform.position, endPosition });

        
    }

}
