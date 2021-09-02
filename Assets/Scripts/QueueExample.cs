using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class QueueExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;

    private void Start()
    {
        Queue queue = new Queue();

        //Prep our data
        int firstPlayerScore = 1;
        int secondPlayerScore = 2;
        int thirdPlayerScore = 3;

        queue.Enqueue(firstPlayerScore);
        queue.Enqueue(secondPlayerScore);
        queue.Enqueue(thirdPlayerScore);

        ShowInformationInQueue(queue);
        queue.Dequeue();

        ShowInformationInQueue(queue);
        queue.Dequeue();

        ShowInformationInQueue(queue);
        queue.Dequeue();

    }

    private void ShowInformationInQueue(Queue queue)
    {
        foreach (var queueitem in queue)
        {
            queueDebug.text += "\n";
            queueDebug.text += $"{queueitem}\n";

        }
    }
}