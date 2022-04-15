using UnityEngine;


public class PlayerShooting2 : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    private float shootDelay = 0.5f;
    private float currentShootRate = 0.5f;


    private void FixedUpdate()
    {
        if (shootDelay < 0f)
        {
            SpawnBullet();
            shootDelay = currentShootRate;
        }
        else
        {
            shootDelay -= Time.deltaTime;
        }
    }

    private void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}
