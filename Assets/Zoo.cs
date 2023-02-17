using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom=new Animal();
        tom.name = "Åè";
        tom.sound = "³Ä¿Ë";

        Animal jerry=new Animal();
        jerry.name = "Á¦¸®";
        jerry.sound = "ÂïÂï";

        tom.PlaySound();
        jerry.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
