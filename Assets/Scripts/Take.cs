using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Take : MonoBehaviour
{
    /**
     * Metodo per incrementare lo score e diminuire il counter degli oggetti rimasti in scena da prendere
     */
    public void ObjectSelected()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score++;
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().RemainingObjects--;
        Destroy(gameObject);
    }
}
