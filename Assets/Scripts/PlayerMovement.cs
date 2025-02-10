using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 moveVector;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveVector);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (moveVector != Vector2.zero)
        {
            spriteRenderer.flipX = (moveVector.x > 0);
        }

        Vector2 tempMove = context.ReadValue<Vector2>();
        tempMove.y = 0;
        moveVector = tempMove * PlayerStats.GetStat(Stats.MOVE_SPEED);

    }
}
