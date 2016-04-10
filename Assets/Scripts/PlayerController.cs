using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 _origin;

    public Vector3 Target { get; set; }

    public AudioSource AudioSource { get; set; }

    public void Start()
    {
        _origin = Target = transform.position;
    }

    // Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Target, step);

	    if (Input.GetMouseButtonDown(1))
	    {
	        Target = _origin;

            if (AudioSource != null)
                AudioSource.Stop();
	    }
    }
}
