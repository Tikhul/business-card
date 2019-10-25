using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StartAnimation : MonoBehaviour
{
    public GameObject userpic;
    public GameObject video;
    public GameObject buttons;
    // Gameobjects' initial positions
    private Vector3 userpicInitialPos;
    private Vector3 videoInitialPos;
    private Vector3 buttonsInitialPos;
    // Gameobjects' target positions
    private Vector3 userpicTargetPos;
    private Vector3 videoTargetPos;
    private Vector3 buttonsTargetPos;

    // Business card image target
    public ImageTargetBehaviour image;

    // Gameobjects' speed
    private float speed = 7f;

    public void Start()
    {
        // Gameobjects' initial positions
        userpicInitialPos = userpic.transform.localPosition;
        videoInitialPos = video.transform.localPosition;
        buttonsInitialPos = buttons.transform.localPosition;
        // Gameobjects' target positions
        userpicTargetPos = new Vector3(userpic.transform.localPosition.x + 5.44f, 
            userpic.transform.localPosition.y, userpic.transform.localPosition.z);
        videoTargetPos = new Vector3(video.transform.localPosition.x,
            video.transform.localPosition.y, video.transform.localPosition.z - 0.6f);
        buttonsTargetPos = new Vector3(buttons.transform.localPosition.x + 7.19f,
            buttons.transform.localPosition.y - 4.23f, buttons.transform.localPosition.z);

}
    // Update is called once per frame
    void FixedUpdate()
    {
        /* If there's no image or image is not tracked, 
         the elements are disabled and moved to their initial positions*/
        if (image == null || image.CurrentStatus == TrackableBehaviour.Status.NO_POSE)
        {
            HideAll();
        }
        else
        {
            ShowAll(); 
        }
    }

    void HideAll()
    {
        userpic.SetActive(false);
        video.SetActive(false);
        buttons.SetActive(false);
        userpic.transform.localPosition = userpicInitialPos;
        video.transform.localPosition = videoInitialPos;
        buttons.transform.localPosition = buttonsInitialPos;
    }

    void ShowAll()
    {
        userpic.SetActive(true);
        video.SetActive(true);
        buttons.SetActive(true);
        userpic.transform.localPosition = Vector3.Lerp(userpic.transform.localPosition, userpicTargetPos, speed * Time.deltaTime);
        video.transform.localPosition = Vector3.Lerp(video.transform.localPosition, videoTargetPos, speed * Time.deltaTime);
        buttons.transform.localPosition = Vector3.Lerp(buttons.transform.localPosition, buttonsTargetPos, speed * Time.deltaTime);
    }

    
}
