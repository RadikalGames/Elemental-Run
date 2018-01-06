using UnityEngine;
using System.Collections;

public enum SwipeType
{
    Up,
    Down,
    Left,
    Right,
    NoSwipe,
};

public class TouchManager : MonoBehaviour
{

    //public members
    public PlayerController instance;

    float maxtime;
    float minDistance;
    float startTime;
    float endTime;
    float swipeDistance;
    float swipeTime;

    Vector3 startPos;
    Vector3 endPos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = t.position;

            }
            else if (t.phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                endPos = t.position;
            }

            swipeDistance = (endPos - startPos).magnitude;
            swipeTime = endTime - startTime;

            if (swipeTime < maxtime && swipeDistance > minDistance)
            {
                if (Swipe() == SwipeType.Up)
                    instance.Jump();
                if (Swipe() == SwipeType.Down)
                    Debug.Log("Call Slide");
                if (Swipe() == SwipeType.Left)
                    Debug.Log("left");
                if (Swipe() == SwipeType.Right)
                    Debug.Log("right");
            }
        }
    }
    SwipeType Swipe()
    {
        Vector2 distance = endPos - startPos;
        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            if (distance.x > 0)
                return SwipeType.Right;
            if (distance.x < 0)
                return SwipeType.Left;
        }
        else if(Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {
            if (distance.y > 0)
                return SwipeType.Up;
            if (distance.y < 0)
                return SwipeType.Down;
        }
        return SwipeType.NoSwipe;
    }
    
}
