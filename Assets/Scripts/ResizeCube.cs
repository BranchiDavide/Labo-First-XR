using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResizeCube : MonoBehaviour
{
    private GameObject cube;
    private Transform cubeT;
    private Vector3 startScale;
    void Start()
    {
        cube = GameObject.Find("ResCube");
        cubeT = cube.GetComponent<Transform>();
        startScale = cubeT.localScale;
    }

    /**
     * Metodo per fare il resize del cubo viola in base al valore preso dallo slider.
     */
    public void Resize(float value)
    {
        cubeT.localScale = new Vector3(startScale.x * value, startScale.y * value, startScale.z * value);
    }
}
