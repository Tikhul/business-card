using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instagram : MonoBehaviour
{
    // Open Instagram on click
    public void InstagramOpen()
    {
        Application.OpenURL("instagram://user?blackvrar={blackvrar}");
    }
}
