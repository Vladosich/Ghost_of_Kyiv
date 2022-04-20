using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int playerHealth;

    private void Start()
    {
        playerHealth = 3;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("EnemyBullet"))
        {
            playerHealth--;
            Debug.Log("Player health: " + playerHealth);
        }
    }
}
