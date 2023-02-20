using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 8f;
    public Rigidbody bulletRigidbody;
    void Start()
    {
        bulletRigidbody=GetComponent<Rigidbody>();  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
           PlayController playController=other.GetComponent<PlayController>();


            if (playController!=null)
            {
                playController.Die();
            }
        }
    }
}
