using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 moveVector;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        rb.AddForce(moveVector);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>() * PlayerStats.GetStat(Stats.MOVE_SPEED);

        spriteRenderer.flipX = (moveVector.x > 0);
    }
}
