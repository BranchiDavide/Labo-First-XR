using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey : MonoBehaviour, IKey
{
    private GameObject chestTop;
    public void UnlockDoor(GameObject keyPlatform)
    {
        keyPlatform.GetComponent<MeshRenderer>().material.color = Color.green;
        // Rimozione freeze su asse Y per permettere di aprire il coperchio del baule
        chestTop.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    void Start()
    {
        chestTop = GameObject.Find("ChestTop");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("ChestKeyCylinder"))
        {
            UnlockDoor(other.gameObject);
        }
    }
}
