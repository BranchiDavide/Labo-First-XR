using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticCard : MonoBehaviour, IKey
{
    private GameObject magneticDoor;
    public void UnlockDoor(GameObject keyPlatform)
    {
        keyPlatform.GetComponent<MeshRenderer>().material.color = Color.green;
        // Rimozione freeze su asse Y per permettere di aprire la porta
        magneticDoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    void Start()
    {
        magneticDoor = GameObject.Find("MagneticDoor");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("KeyCardBase"))
        {
            UnlockDoor(other.gameObject);
        }
    }
}
