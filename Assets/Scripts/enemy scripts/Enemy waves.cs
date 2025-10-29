using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    [Header("Wave Settings")]
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public float timeBetweenEnemies = 0.5f;
    public int startEnemyCount = 3;      // How many enemies to spawn on the first wave
    public int enemyIncreasePerWave = 2; // How many more enemies each new wave adds

    private int currentWaveIndex = 0;

    [SerializeField] private TextMeshProUGUI waveText;

    void Start()
    {
        StartCoroutine(SpawnWaves());
        updateUiWave();

    }

    IEnumerator SpawnWaves()
    {
        int enemyCount = startEnemyCount;

        // Infinite wave loop
        while (true)
        {
            currentWaveIndex++;
            updateUiWave(); 
            Debug.Log($"Spawning Wave {currentWaveIndex} with {enemyCount} enemies");

            // Spawn enemies for this wave
            for (int i = 0; i < enemyCount; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(timeBetweenEnemies);
            }

            // Wait before starting the next wave
            yield return new WaitForSeconds(timeBetweenWaves);

            // Increase difficulty for next wave
            enemyCount += enemyIncreasePerWave;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void updateUiWave()
    {
        waveText.text = "Wave: " + currentWaveIndex.ToString();
    }
}
