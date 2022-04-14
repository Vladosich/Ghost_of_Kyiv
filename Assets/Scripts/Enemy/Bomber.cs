using UnityEngine;

public class Bomber : Enemy
{
    [SerializeField]private float speed;
    private Vector2 moveDirection = new Vector2(0,-0.01f);

    private void FixedUpdate()
    {
        transform.Translate(moveDirection);
    }
}
