using UnityEngine;

public class Bomber : Enemy
{
    private Vector2 moveDirection = new Vector2(0,-0.01f);

    private readonly float bomberHealthPoint = 3f;

    private void Start()
    {
        healthPoints = bomberHealthPoint;
    }

    private void FixedUpdate()
    {
        transform.Translate(moveDirection);
    }
}
