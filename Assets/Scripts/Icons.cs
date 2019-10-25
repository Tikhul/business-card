using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons : MonoBehaviour
{
    private float speed = 0.5f;
    public void IconsRotation()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, 
            new Quaternion(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z, transform.rotation.w),
            speed * Time.deltaTime);
    }
}
