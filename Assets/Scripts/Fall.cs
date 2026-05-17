using UnityEngine;

public class Fall : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed = 300f;

    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 nextPos = rb.position + Vector2.down * speed * Time.fixedDeltaTime;

        rb.MovePosition(nextPos);

        if(nextPos.y <= -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Fall‘¤“–‚½‚è");
    }
}
