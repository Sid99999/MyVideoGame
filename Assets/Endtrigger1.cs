using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger1 : MonoBehaviour
{
    




    public GameManager1 gameManager;

    void OnTriggerEnter()
    {

        gameManager.CompleteLevel();
    }

}
