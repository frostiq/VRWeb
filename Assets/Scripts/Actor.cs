using UnityEngine;
using VRStandardAssets.Utils;

// This script is a simple example of how an interactive item can
// be used to change things on gameobjects by handling events.
public class Actor : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem _interactiveItem;
    private PlayerController _player;
    private movie _movie;
    private AudioSource _audioSource;

    public void Start()
    {
        _interactiveItem = GetComponent<VRInteractiveItem>();
        if(_interactiveItem == null) Debug.LogError("_interactiveItem == null");

        _player = GetComponentInParent<PlayerReference>().Player;
        if(_player == null) Debug.LogError("_player == null");

        _movie = GetComponentInParent<movie>();
        _audioSource = GetComponentInParent<AudioSource>();
        
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
        _player.Target = transform.position;

        if (_movie != null)
            _movie.Play(_audioSource);
    }

}