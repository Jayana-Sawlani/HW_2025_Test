using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        input = new Vector3(horizontal, 0f, vertical).normalized;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = input * moveSpeed;
        Vector3 newPosition = rb.position + velocity * Time.fixedDeltaTime;

        rb.MovePosition(newPosition);
    }
}

