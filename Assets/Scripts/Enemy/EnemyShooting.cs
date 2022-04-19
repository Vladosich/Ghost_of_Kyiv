using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject enemyBulletPrefab;

    private Transform player;
    [SerializeField] Transform shootDirection;

    private float shootDelay = 2f;
    private float currentShootRate = 2f;

    private float rotationOffset = 90f;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 difference = player.position - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + rotationOffset);
    }

    private void FixedUpdate()
    {
        if (shootDelay < 0f)
        {
            SpawnEnemyBullet();
            shootDelay = currentShootRate;
        }
        else
        {
            shootDelay -= Time.deltaTime;
        }
    }

    private void SpawnEnemyBullet()
    {
        Instantiate(enemyBulletPrefab, shootDirection.position, transform.rotation);
    }

   
}
