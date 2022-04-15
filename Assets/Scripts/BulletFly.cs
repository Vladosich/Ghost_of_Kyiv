using UnityEngine;

public class BulletFly : MonoBehaviour
{
    private Vector2 moveDirection = new Vector2(0, 0.2f);

    private void FixedUpdate()
    {
        transform.Translate(moveDirection);
    }
}
