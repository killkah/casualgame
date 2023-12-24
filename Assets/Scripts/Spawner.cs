using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private bool isVertical = true;
    [SerializeField] private float spawnTimer = 5;
    [SerializeField] private float k = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
        // Запустить
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Таймер раз в секунду
    IEnumerator Timer()
    {
        while (true)
        {
            SpawnEnemy();
            if (spawnTimer > 0.5) spawnTimer = spawnTimer - k;
            yield return new WaitForSeconds(1);
        }
    }

    private void SpawnEnemy()
    {
        if (isVertical)
        {
            // Считаем Y
            float topY = transform.position.y + transform.localScale.y / 2;
            float bottomY = transform.position.y - transform.localScale.y / 2;
            // Случайное число
            float spawnY = Random.Range(bottomY, topY);
            // Позиция спавна
            Vector3 enemyPos = new Vector3(transform.position.x, spawnY, 0);
            int enemyIndex = Random.Range(0, enemys.Length);
            Instantiate(enemys[enemyIndex], enemyPos, Quaternion.identity);
        }
        else
        {
            // Считаем Y
            float leftX = transform.position.x - transform.localScale.x / 2;
            float rightX = transform.position.x + transform.localScale.x / 2;
            // Случайное число
            float spawnX = Random.Range(leftX, rightX);
            // Позиция спавна
            Vector3 enemyPos = new Vector3(spawnX, transform.position.y, 0);
            int enemyIndex = Random.Range(0, enemys.Length);
            Instantiate(enemys[enemyIndex], enemyPos, Quaternion.identity);
        }
    }
}
