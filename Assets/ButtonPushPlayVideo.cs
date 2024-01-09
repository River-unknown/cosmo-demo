using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushPlayVideo : MonoBehaviour
{
    [SerializeField] private Canvas vidPlayer;

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(" clicked");
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x=>PlayVideo());

    }

    // Update is called once per frame
    public void PlayVideo()
    {
        Debug.Log("button clicked");
    }
   
}