using UnityEngine;

public class scale:MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        setrandomGravityScale();

    }
    private void setrandomGravityScale()
    {
        rb = GetComponent<Rigidbody2D>();
        float random = Random.Range(-0.1f, -0.5f);
        rb.gravityScale = random;
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //if (collision.CompareTag("delete")) {
    //    //    Destroy(gameObject);
    //    //}
    //}
}
