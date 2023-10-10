using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloresAmarillas1 : MonoBehaviour
{



    private void OnCollisionerEnter (Collision colision)
    {

    }


    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Jugador");
        {
            Destroy (gameObject);
            other.GetComponent<CaminataPlayer>().AmaAJuntar -= 1;
            other.GetComponent<CaminataPlayer>().AmaActuales += 1;

        }

    }
}
