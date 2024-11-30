using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    private GameObject drawer1;
    private GameObject drawer2;
    void Start()
    {
        drawer1 = GameObject.Find("Drawer1");
        drawer2 = GameObject.Find("Drawer2");
    }
    
    /**
     * Metodo per avviare la coroutine che apre gradualmente il primo cassetto
     */
    public void OpenDrawer1()
    {
        StartCoroutine(OpenDrawer1Coroutine());
    }

    /**
     * Metodo per avviare la coroutine che apre gradualmente il secondo cassetto
     */
    public void OpenDrawer2()
    {
        StartCoroutine(OpenDrawer2Coroutine());
    }

    /**
     * Coroutine per aprire il primo cassetto
     */
    private IEnumerator OpenDrawer1Coroutine()
    {
        while(drawer1.transform.localPosition.x > 1.223f)
        {
            drawer1.transform.Translate(-0.01f, 0f, 0f);
            yield return new WaitForSeconds(0.01f);
        }
    }

    /**
     * Coroutine per aprire il secondo cassetto
     */
    private IEnumerator OpenDrawer2Coroutine()
    {
        while (drawer2.transform.localPosition.x > 1.025f)
        {
            drawer2.transform.Translate(-0.01f, 0f, 0f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
