using UnityEngine;
using VRStandardAssets.Utils;

// This script is a simple example of how an interactive item can
// be used to change things on gameobjects by handling events.
public class Actor : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem _interactiveItem;
    private PlayerController _player;

    public void Start()
    {
        _interactiveItem = GetComponent<VRInteractiveItem>();
        if(_interactiveItem == null) Debug.LogError("_interactiveItem == null");

        _player = GetComponentInParent<PlayerReference>().Player;
        if(_player == null) Debug.LogError("_player == null");
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
        _player.Target = transform;
    }

}