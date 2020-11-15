using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitworld_que2_2: MonoBehaviour
{
    private float Left, Right, Down, Up;
    private float playerSize;

    void Start()
    {

        Collider2D playerColl = GetComponent<Collider2D>();
        playerSize = playerColl.bounds.extents.x;
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 top = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        Left = bottom.x + playerSize;
        Right = top.x - playerSize;
        Down = bottom.y + playerSize;
        Up = top.y - playerSize;


    }

    void Update()
    {
        Vector3 pos = transform.position;
        //left and right
        if (pos.x < Left) pos.x = Left;
        if (pos.x > Right) pos.x = Right;
        //up and down
        if (pos.y < Down) pos.y = Down;
        if (pos.y > Up) pos.y = Up;
        //current position
        transform.position = pos;
    }
}