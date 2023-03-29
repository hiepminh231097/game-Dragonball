
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 StartingVelocity;
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Destroy(gameObject);
    }

}
