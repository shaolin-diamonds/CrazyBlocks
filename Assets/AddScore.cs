using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }
}
