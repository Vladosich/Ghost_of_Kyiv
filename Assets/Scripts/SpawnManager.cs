using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject bomberPrefab;
    private readonly Vector2[] bomberSpawnPosition = new Vector2[3] {new Vector2(-2.2f,5.6f),
                                                            new Vector2(0,5.6f),
                                                            new Vector2(2.2f,5.6f)};

    void Start()
    {
        BomberSpawn();
    }

    private void BomberSpawn()
    {
        for (int i = 0; i < bomberSpawnPosition.Length; i++)
        {
            Instantiate(bomberPrefab, bomberSpawnPosition[i], transform.rotation);
        }
    }
}
