using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCamara : MonoBehaviour
{
    public float mouseSensibility = 5;
    Camera Camara;
    float cameraRotation = 0;


    // Start is called before the first frame update
    void Start()
    {
        Camara = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXInput = Input.GetAxis("Mouse X");
        float mouseYInput = Input.GetAxis("Mouse Y");

        this.transform.Rotate(Vector3.up * mouseXInput * mouseSensibility);

        cameraRotation -= mouseYInput * mouseSensibility;
        cameraRotation = Mathf.Clamp(cameraRotation,-90,90);
        Camara.transform.localEulerAngles = new Vector3(cameraRotation, 0, 0);

    }
}
