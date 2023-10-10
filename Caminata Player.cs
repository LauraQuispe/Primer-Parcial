using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaminataPlayer : MonoBehaviour
{


    public float horizontal;
    public float vertical;
    public float speed;

    public float rotationSpeed;

    Rigidbody rb;


    public float RosasAJuntar;
    public float RosasActuales;
    public float RosasGuardadas;

    public float AmaAJuntar;
    public float AmaActuales;
    public float AmaGuardadas;



    public bool Gane;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 direction = transform.forward * vertical + transform.right * horizontal;

        transform.position += direction * speed * Time.deltaTime;

        if (RosasAJuntar == RosasGuardadas && AmaAJuntar == AmaGuardadas)
        {
            Victoria();
        }

    }


    void Victoria()
    {
        SceneManager.LoadScene("Victoria");
    }


}
