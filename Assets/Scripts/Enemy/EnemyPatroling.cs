using UnityEngine;

public class EnemyPatroling : MonoBehaviour
{
    private float enemySpeed = 2f;
    [SerializeField] private Transform[] patrolPoints;
    private int currentPoint = 0;
    [SerializeField]private bool positiveWay = true;


    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        MoveToPoint();
        if (Vector2.Distance(transform.position, patrolPoints[currentPoint].position) <= 0.1f)
        {
            currentPoint++;
        }
        
    }



    private void MoveToPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPoint].position, enemySpeed * Time.deltaTime);
    }

}
