using UnityEngine;

public class delete : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Destroy(collision.gameObject);
        }
    }
}
