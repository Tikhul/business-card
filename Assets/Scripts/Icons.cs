using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons : MonoBehaviour
{
    public void Calling()
    {
        Application.OpenURL("tel://+79686640245");
    }

    public void Messaging()
    {
        Application.OpenURL("sms:+79686640245");
    }

    public void Telegraming()
    {
        Application.OpenURL("https://t.me/pashaivanov");
    }

    public void Emailing()
    {
        Application.OpenURL("mailto:pavel@blackvr.org");
    }
}
