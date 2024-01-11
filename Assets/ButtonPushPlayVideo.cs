using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushPlayVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    void Start()
    {
        Debug.Log("HEELO");
        //GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => PlayVideo());
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => PlayVideo());
        Debug.Log("BUTTON ...");
        //PlayVideo();
    }

    public void PlayVideo()
    {
        Debug.Log("BUTTON ");

        if (videoPlayer != null)
        {
            Debug.Log("Playing Video...");

            // Check if the video is already playing; if not, play it
            if (!videoPlayer.isPlaying)
            {
                // Play the video
                videoPlayer.Play();
                Debug.Log("Video started");
            }
            else
            {
                Debug.Log("Video is already playing");
            }
        }
        else
        {
            Debug.LogError("No VideoPlayer attached");
        }
    }
}