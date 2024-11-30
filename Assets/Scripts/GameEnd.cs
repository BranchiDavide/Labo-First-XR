using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Quando il player esce dalla porta finisce il gioco, si potrebbe implementare il ritorno al menu
        if (other.gameObject.tag.Equals("player"))
        {
            Application.Quit();
        }
    }
}
