using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using Random = Unity.Mathematics.Random;


public class StartandSave : MonoBehaviour
{
    // Start is called before the first frame update
    //Game Done!

    public GameObject parentCanvas;

    void Start()
    {
        parentCanvas = GameObject.FindGameObjectWithTag("ButtonController");
        parentCanvas.GetComponent<buttonsystem>().LoadStart();
    }
}
