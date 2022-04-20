using UnityEngine;

public class BulletDestoyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Upgrade") && !collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
        }
    }
}
