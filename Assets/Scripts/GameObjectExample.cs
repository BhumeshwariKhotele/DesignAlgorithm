using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameObjectExample : MonoBehaviour
{
    [SerializeField] private GameObject Cube_one;
    [SerializeField] private GameObject Cube_two;
    [SerializeField] private GameObject Cube_third;
    private int pos=0;
    
    
    private void Start()
    {
        Queue<GameObject> gameobjectQueue = new Queue<GameObject>();

        //Prep our data
      

        gameobjectQueue.Enqueue(Cube_one);
        gameobjectQueue.Enqueue(Cube_two);
        gameobjectQueue.Enqueue(Cube_third);

        ShowInformationInQueue(gameobjectQueue);
        gameobjectQueue.Dequeue();

        ShowInformationInQueue(gameobjectQueue);
        gameobjectQueue.Dequeue();

        ShowInformationInQueue(gameobjectQueue);
        gameobjectQueue.Dequeue();

    }

    private void ShowInformationInQueue(Queue<GameObject> gameobjectqueue)
    {
        foreach (GameObject gameitem in gameobjectqueue)
        {
             Instantiate(gameitem, transform.position + new Vector3(pos, 0, 0), Quaternion.identity);
            gameitem.SetActive(true);

            pos += 2;

        }
    }
}