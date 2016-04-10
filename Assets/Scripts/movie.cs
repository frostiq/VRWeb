using UnityEngine;

public class movie : MonoBehaviour {
    public MovieTexture movTexture;
	// Use this for initialization
	public void Play (AudioSource audioSource) {
        GetComponent<Renderer>().material.mainTexture = movTexture;
        movTexture.Play();
	    audioSource.clip = movTexture.audioClip;
        audioSource.PlayDelayed(2f);
	}

}
