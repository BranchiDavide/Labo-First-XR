using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Take : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectSelected()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score++;
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().RemainingObjects--;
        Destroy(gameObject);
    }
}
