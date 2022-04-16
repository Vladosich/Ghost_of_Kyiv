using UnityEngine;

public class Upgrade : MonoBehaviour
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
}
