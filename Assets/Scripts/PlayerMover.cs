using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Transform[] lanePoints;

    private int currrentLane = 1;


    private void Start()
    {
        MovetoLane();
    }

    private void MovetoLane()
    {
        transform.position = lanePoints[currrentLane].position;
    }

    public void MoveLeft()
    {
        if(currrentLane <= 0)
        {
            return;
        }

        currrentLane--;
        MovetoLane();
    }

    public void MoveRight()
    {
        if (currrentLane >= lanePoints.Length - 1)
        {
            return;
        }

        currrentLane++;
        MovetoLane();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fall"))
        {
            Debug.Log("‚ ‚½");

            enabled = false;
            GameManager.instance.GameOver();
        }
    }
}
