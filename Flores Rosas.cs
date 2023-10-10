using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloresAmarillas : MonoBehaviour
{

    private void OnCollisionerEnter(Collision colision)
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador") ;
        {
            Destroy(gameObject);
            other.GetComponent<CaminataPlayer>().RosasAJuntar -= 1;
            other.GetComponent<CaminataPlayer>().RosasActuales += 1;

        }

    }

}
