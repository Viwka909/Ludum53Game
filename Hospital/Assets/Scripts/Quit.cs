using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Quitting()
    {
        Application.Quit();
        Debug.Log("Quitted");
    }    
}
