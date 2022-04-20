using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject enemyBulletPrefab;

    private Transform player;
    [SerializeField] Transform shootDirection;

    private float shootDelay;

    private float rotationOffset = 90f;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();

        shootDelay = Random.Range(0f, 5f);
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
            shootDelay = RandomShootRate();
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

    private float RandomShootRate()
    {
        float minShootRate = 3f;
        float maxShootRate = 10f;
        return Random.Range(minShootRate, maxShootRate);
    }

   
}
