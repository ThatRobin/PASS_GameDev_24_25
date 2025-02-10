using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Vector2 launchDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(launchDirection * PlayerStats.GetStat(Stats.BULLET_SPEED));
    }
}
