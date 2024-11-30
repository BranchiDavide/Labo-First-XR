using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKey
{
    // Metodo che verrà implementato per sbloccare le porte e i bauli
    void UnlockDoor(GameObject keyPlatform);
}
