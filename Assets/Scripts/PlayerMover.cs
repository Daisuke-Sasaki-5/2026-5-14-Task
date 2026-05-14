using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private RectTransform rectTransform;

    [SerializeField] RectTransform[] lanePoints;

    private int currrentLane = 1;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        MovetoLane();
    }

    private void MovetoLane()
    {
        rectTransform.anchoredPosition = lanePoints[currrentLane].anchoredPosition;
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
}
