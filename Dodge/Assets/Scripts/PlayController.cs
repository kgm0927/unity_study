using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody playerRigidbody;
    public float speed = 8f;
    
    void Start()
    {
        playerRigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       float xInput=Input.GetAxis("Horizontal");
       float zInput = Input.GetAxis("Vertical");

        float xSpeed=xInput*speed;
        float zSpeed=zInput*speed;

        Vector3 newVelocity=new Vector3(xSpeed,0f,zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {// �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);


        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();
        // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
        gameManager.EndGame();
    }
}
