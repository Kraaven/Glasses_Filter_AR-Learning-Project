using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsystem : MonoBehaviour
{ 
    

    public void ShowMask()
    {
        GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled = true;
    }
    
    public void ShowCat()
    {
        GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled = true;
    }
    
    public void ShowMono()
    {
        GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled = true;
    }
}
