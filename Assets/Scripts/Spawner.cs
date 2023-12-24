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
        // ���������
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ������ ��� � �������
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
            // ������� Y
            float topY = transform.position.y + transform.localScale.y / 2;
            float bottomY = transform.position.y - transform.localScale.y / 2;
            // ��������� �����
            float spawnY = Random.Range(bottomY, topY);
            // ������� ������
            Vector3 enemyPos = new Vector3(transform.position.x, spawnY, 0);
            int enemyIndex = Random.Range(0, enemys.Length);
            Instantiate(enemys[enemyIndex], enemyPos, Quaternion.identity);
        }
        else
        {
            // ������� Y
            float leftX = transform.position.x - transform.localScale.x / 2;
            float rightX = transform.position.x + transform.localScale.x / 2;
            // ��������� �����
            float spawnX = Random.Range(leftX, rightX);
            // ������� ������
            Vector3 enemyPos = new Vector3(spawnX, transform.position.y, 0);
            int enemyIndex = Random.Range(0, enemys.Length);
            Instantiate(enemys[enemyIndex], enemyPos, Quaternion.identity);
        }
    }
}
