using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPlayer : MonoBehaviour
{

    public Transform Jugador;
    public float mouseSensitivity = 2;

    float camaraVerticalRotation = 0;

    bool lockedCursor = true;

    // Start is called before the first frame update
    void Start()
    {
       Cursor.visible = false; 
       Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        camaraVerticalRotation -= inputY;
        camaraVerticalRotation = Mathf.Clamp(camaraVerticalRotation, -90f, 90f);

        transform.localEulerAngles = Vector3.right * camaraVerticalRotation;

        Jugador.Rotate(Vector3.up * inputX);

    }
}
