using System;
using UnityEngine;
using VRStandardAssets.Utils;

// This script is a simple example of how an interactive item can
// be used to change things on gameobjects by handling events.
public class Actor : MonoBehaviour
{
    private VRInteractiveItem _interactiveItem;

    public void Start()
    {
        _interactiveItem = GetComponent<VRInteractiveItem>();
    }

    private void OnEnable()
    {
        _interactiveItem.OnClick += HandleClick;
    }


    private void OnDisable()
    {
        _interactiveItem.OnClick -= HandleClick;
    }

    //Handle the Click event
    private void HandleClick()
    {
        Debug.Log("Show click state"+DateTime.Now);
    }

}