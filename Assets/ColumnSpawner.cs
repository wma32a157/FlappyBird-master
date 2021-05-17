using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject column;
    public float delay = 3f;
    public float randomDelay = 2f;
    public float spawnX = 4f;
    public float spawnYmin = -2;
    public float spawnXman = 1;
    IEnumerator Start()

    {
        while(true)
        {
            // 3�� ���� ��ġ
            yield return new WaitForSeconds(delay
                + Random.Range(-randomDelay, randomDelay));
            // ��ġ �Ҷ� y���� ��������
            Vector3 pos;
            pos.z = 0;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnXman);
            Instantiate(column, pos, column.transform.rotation);

            // ������Ű��  x���� ������.
            yield return new WaitForSeconds(delay);
        }

    }

}
