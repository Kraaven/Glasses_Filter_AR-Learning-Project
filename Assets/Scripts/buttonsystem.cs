using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Random = UnityEngine.Random;

public class buttonsystem : MonoBehaviour
{
    public int face;
    public int color;
    
    public GameObject currentfilter;
    public Material currentColor;
    public Material Red;
    public Material Green;
    public Material Blue;
    
    public bool ini = false;
    public void LoadStart()
    {
        if (ini == false)
        {
            int temp = Random.Range(0, 3);

            switch (temp)
            {
                case 0:
                    ShowCat();
                    break;
                
                case 1:
                    ShowMask();
                    break;
                case 2:
                    ShowMono();
                    break;
            }

            temp = Random.Range(0, 3);
            switch (temp)
            {
                case 0:
                    setgreen();
                    break;
                
                case 1:
                    setblue();
                    break;
                case 2:
                    Setred();
                    break;
            }

            ini = true;
        }
        else
        {
            switch (face)
            {
                case 0:
                    ShowCat();
                    break;
                
                case 1:
                    ShowMask();
                    break;
                case 2:
                    ShowMono();
                    break;
            }

            switch (color)
            {
                case 0:
                    setgreen();
                    break;
                
                case 1:
                    setblue();
                    break;
                case 2:
                    Setred();
                    break;
            }
        }

        
    }
    
    

    public void ShowMask()
    {
        GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled = true;
        currentfilter = GameObject.FindGameObjectWithTag("Mask");
        face = 1;
        currentfilter.GetComponent<Renderer>().material = currentColor;
    }
    
    public void ShowCat()
    {
        GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled = true;
        currentfilter = GameObject.FindGameObjectWithTag("Cat");
        face = 0;
        currentfilter.GetComponent<Renderer>().material = currentColor;
    }
    
    public void ShowMono()
    {
        GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled = true;
        currentfilter = GameObject.FindGameObjectWithTag("Monocle");
        face = 2;
        currentfilter.GetComponent<Renderer>().material = currentColor;
    }

    public GameObject getcurrent()
    {
        if (GameObject.FindGameObjectWithTag("Cat").GetComponent<MeshRenderer>().enabled == true)
        {
            return GameObject.FindGameObjectWithTag("Cat");
        }
        if(GameObject.FindGameObjectWithTag("Mask").GetComponent<MeshRenderer>().enabled == true)
        {
            return GameObject.FindGameObjectWithTag("Mask");
        }
        if(GameObject.FindGameObjectWithTag("Monocle").GetComponent<MeshRenderer>().enabled == true)
        {
            return GameObject.FindGameObjectWithTag("Monocle");
        }

        return GameObject.FindGameObjectWithTag("Monocle");
    }

    public void Setred()
    {
        getcurrent().GetComponent<Renderer>().material = Red;
        currentColor = Red;
        color = 2;
    }

    public void setblue()
    {
        getcurrent().GetComponent<Renderer>().material = Blue;
        currentColor = Blue;
        color = 1;
    }

    public void setgreen()
    {
        getcurrent().GetComponent<Renderer>().material = Green;
        currentColor = Green;
        color = 0;
    }
}
