using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;


public class Video : MonoBehaviour
{
    // Business card image target
    public ImageTargetBehaviour image;
    // Video inside the plain quad
    public VideoPlayer videoPlayer;
    

    // Update is called once per frame
    void Update()
    {
        // If there's no image or image is not tracked, the video is paused
        if(image == null || image.CurrentStatus == TrackableBehaviour.Status.NO_POSE)
        {
            videoPlayer.Pause();
           // Debug.Log("Video paused");
        }
        else
        {
            videoPlayer.Play();
           // Debug.Log("Video playing");
        }
        
    }
}
