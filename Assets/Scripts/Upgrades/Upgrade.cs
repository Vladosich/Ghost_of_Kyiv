using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    private Vector2 moveDirection = new Vector2(0, -0.01f);

    private void FixedUpdate()
    {
        MoveUpgrade();
    }

    private void MoveUpgrade()
    {
        transform.Translate(moveDirection);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
