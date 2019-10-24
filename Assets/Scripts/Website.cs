using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Website : MonoBehaviour
{
    // Open website on click
    public void WebsiteOpen()
    {
        Application.OpenURL("https://blackvr.org/");
    }
}
