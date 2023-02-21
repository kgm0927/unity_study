using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText;           // ���� �Ⱓ�� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;         // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;      // ���� �Ⱓ
    private bool isGameover;        // ���ӿ��� ����

    // Start is called before the first frame update
    void Start()
    {
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //���ӿ����� �ƴ� ����
        if(!isGameover)
        {
            // ���� �Ⱓ ����
            surviveTime+=Time.deltaTime;
            // ������ ���� �Ⱓ�� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time:" + (int)surviveTime;
        }
        else
        {
            // ���ӿ����� ���¿��� RŰ�� ���� ���
            if(Input.GetKeyDown(KeyCode.R))
            {
                // SampleScene ���� �ε�
                SceneManager.LoadScene("sampleScene");
            }
        }
    }

    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ Ȱ��ȭ
        gameoverText.SetActive(true);

        // BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");


        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if(bestTime < surviveTime)
        {
            // �ְ� ��� ���� ���� ���� �ð� ������ ����
            bestTime=surviveTime;
            // ����� �ְ� ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);

        }

        // �ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        recordText.text = "Best Time: " + (int)bestTime;
    }
}
