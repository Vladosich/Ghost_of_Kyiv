using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject bomberPrefab;
    private Vector2[] bomberSpawnPosition = new Vector2[3] {new Vector2(-2.2f,5.6f),
                                                            new Vector2(0,5.6f),
                                                            new Vector2(2.2f,5.6f)};

    void Start()
    {
        bomberSpawn();
    }

    void Update()
    {
        
    }

    private void bomberSpawn()
    {
        for (int i = 0; i < bomberSpawnPosition.Length; i++)
        {
            Instantiate(bomberPrefab, bomberSpawnPosition[i], transform.rotation);
        }
    }
}
