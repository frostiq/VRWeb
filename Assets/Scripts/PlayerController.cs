using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    public Transform Target { get; set; }

    public void Start()
    {
        Target = transform;
    }

    // Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Target.position, step);
    }
}
