using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalKey : MonoBehaviour, IKey
{
    private GameObject normalDoor;
    public void UnlockDoor(GameObject keyPlatform)
    {
        keyPlatform.GetComponent<MeshRenderer>().material.color = Color.green;
        // Rimozione freeze su asse Y per permettere di aprire la porta
        normalDoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        // Distruggere la key
        Destroy(gameObject);
    }
    void Start()
    {
        normalDoor = GameObject.Find("NormalDoor");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("KeyCylinder"))
        {
            UnlockDoor(other.gameObject);
        }
    }
}
