using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bulletPrefab; // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;    // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;     // �ִ� ���� �ֱ�

    private Transform target;   //�߻��� ���
    private float spawnRate; //���� �ֱ�
    private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ.
        timeAfterSpawn = 0f;

        // ź�� ���� ������ spawnRateMin �� spawnRateMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin,spawnRateMax);

        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >=spawnRate)
        {
            // ������ �ð��� ����
            timeAfterSpawn= 0f;


            // bulletPrefab �� ��������
            // transfrom.position ��ġ�� transfrom.rotation ȸ������ ����
            GameObject bullet=Instantiate(bulletPrefab,transform.position,transform.rotation);


            // ������ ���� ������Ʈ�� ���� ������ Ÿ���� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            // ���� �� ���� ������ spawnRateMin, spawnRateMax ���̿��� ���� ����

            spawnRate=Random.Range(spawnRateMin, spawnRateMax);
        }
        
    }
}
