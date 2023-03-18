using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private float minZoomDist, maxZoomDist;

    [SerializeField] private float zoomSpeed;
    [SerializeField] private float zoomModifier;

    private Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Zoom();
    }

    private void Zoom()
    {
        zoomModifier = Input.GetAxis("Mouse ScrollWheel");

        float dist = Vector3.Distance(transform.position, cam.transform.position);

        if (dist < minZoomDist && zoomModifier > 0f)
            return;
        else if (dist > maxZoomDist && zoomModifier <0f)
            return;

        cam.transform.position += cam.transform.forward * zoomModifier * zoomSpeed;
    }
}
