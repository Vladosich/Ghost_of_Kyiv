using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float healthPoints;
    protected float bulletDamage = 1f;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(bulletDamage);
        DestroyIfDead(healthPoints);
    }

    protected void TakeDamage(float damage)
    {
        healthPoints -= damage;
    }

    protected void DestroyIfDead(float healthPoints)
    {
        if(healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
