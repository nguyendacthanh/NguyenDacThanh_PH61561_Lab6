using Unity.VisualScripting;
using UnityEngine;

public class arrow :MonoBehaviour
{
    public float speed = 10f;
    public void Start()
    {

   
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    
}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
            Destroy(gameObject, 5f);
        }
    }

}
