using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canasta : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador")
        {
            other.GetComponent<CaminataPlayer>().RosasActuales -= 1;
            other.GetComponent<CaminataPlayer>().RosasGuardadas += 1;

            other.GetComponent<CaminataPlayer>().AmaActuales -= 1;
            other.GetComponent<CaminataPlayer>().AmaGuardadas += 1;

        
        }


    }

}
