using UnityEngine;

public class Movement : MonoBehaviour
{
    public float SpeedMultiplyer;

    private Rigidbody _rigidbody;

    private Transform _transform;
    
	// Use this for initialization
	void Start ()
	{
	    _transform = GetComponentInChildren<Transform>();
	    _rigidbody = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        float input = Input.GetAxis("Vertical");

        _rigidbody.AddForce(_transform.forward * input * SpeedMultiplyer);
    }
}
