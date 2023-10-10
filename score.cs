using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{

    public TextMeshProUGUI contadorAma;
    public TextMeshProUGUI contadorRosas;

    public CaminataPlayer player;

    void Update()
    {
        contadorAma.text = "Mimosas en Mano:" + player.AmaActuales.ToString();
        contadorRosas.text = "Rosas en Mano:" + player.RosasActuales.ToString();
    }
}
