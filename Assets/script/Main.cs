using UnityEngine;

public class Main :MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;
    

    public GameObject arrow;
    public float arrowSpeed = 5f;
    public Transform spawnPoint;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
   
        movement.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnArrow();
            animator.SetTrigger("active");
            
        }

    }
    void SpawnArrow()
    {
        GameObject arrows = Instantiate(arrow, spawnPoint.position, Quaternion.identity);
        Rigidbody2D muiten= arrows.GetComponent<Rigidbody2D>();
        if (arrow!=null) { 
            muiten.linearVelocity= new Vector2 (5f,0);
        }
    }
}
