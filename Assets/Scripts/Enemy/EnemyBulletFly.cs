using UnityEngine;

public class EnemyBulletFly : MonoBehaviour
{
    private float speed = 0.05f;
    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed);
    }
}
