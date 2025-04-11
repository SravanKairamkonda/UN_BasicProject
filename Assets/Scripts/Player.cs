using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [Range(0, 10)]
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
