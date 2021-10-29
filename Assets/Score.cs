using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    float startingYPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        if (transform.position.x <= -15)
        {
            transform.position += Vector3.right * 30f;
        }
    }
}
