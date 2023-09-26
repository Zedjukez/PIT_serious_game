using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCheck : MonoBehaviour
{
    [SerializeField] private int boxNumber;
    [SerializeField] private scoreSO score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(boxNumber.ToString()))
        {
            score.addScore(1);
            Destroy(collision.gameObject);
        }
    }
}
