using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float speedMultiplyer;

    private Rigidbody rigidbody;
    
	// Use this for initialization
	void Start ()
	{
	    var transform = GetComponentInChildren<Transform>();
	    rigidbody = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        float input = Input.GetAxis("Vertical");

        rigidbody.AddForce(transform.forward * input * speedMultiplyer);
    }
}
