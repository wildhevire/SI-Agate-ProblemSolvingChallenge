using UnityEngine;

public class PushBall : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float speed;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        Push();
    }

    private void Push()
    {
        var xForce = Random.Range(-1f, 1f);
        var yForce = Random.Range(-1f, 1f);
        var force = new Vector2(xForce, yForce);
        rigidBody2D.velocity = force.normalized * speed;
    }
}
