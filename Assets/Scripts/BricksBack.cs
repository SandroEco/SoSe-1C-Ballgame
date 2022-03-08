using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksBack : MonoBehaviour
{
    public GameObject Ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(Ball, new Vector3(-1, 9, 0), Quaternion.identity);
    }
}
