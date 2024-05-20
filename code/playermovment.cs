using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class playerscript : MonoBehaviour
{

    [SerializeField] private float speed;
    private Rigidbody2D body;
    private bool grounded;

    private Animator anm;

   

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anm = GetComponent<Animator>();
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y );

        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput <-0.01f)
            transform.localScale = new Vector3(-1,1,1);

        if (Input.GetKey(KeyCode.Space) && grounded)
            jump();

        anm.SetBool("run", horizontalInput != 0);
        anm.SetBool("grounded", grounded);
    }
    private void jump()
    {
        body.velocity = new Vector2(body.velocity.x, 4);
        anm.SetTrigger("jump");
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

}
