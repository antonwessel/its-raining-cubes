using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private const float SpawnLimitX = 1.8f;
    private const float SpawnY = 4.5f;
    private const float SpawnZ = 0f;

    [SerializeField] private GameObject fallingCubePrefab;

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (isActiveAndEnabled)
        {
            var spawnX = Random.Range(-SpawnLimitX, SpawnLimitX);
            Instantiate(fallingCubePrefab, new Vector3(spawnX, SpawnY, SpawnZ), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
