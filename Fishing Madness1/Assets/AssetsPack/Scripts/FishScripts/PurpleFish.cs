﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]


public class PurpleFish : MonoBehaviour
{
    public List<Transform> points;

    public int nextID;

    int idChangeValue = 1;
    public float speed = 2;

    private void Reset()
    {
        Init();
    }

    void Init()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;

        GameObject root = new GameObject(name + "_Root");

        root.transform.position = transform.position;

        transform.SetParent(transform);

        GameObject waypoints = new GameObject("Waypoints");

        GameObject l1 = new GameObject("Point1");
        l1.transform.SetParent(waypoints.transform);
        l1.transform.position = root.transform.position;

        GameObject l2 = new GameObject("Points2");
        l2.transform.SetParent(waypoints.transform);
        l2.transform.position = root.transform.position;

        points = new List<Transform>();
        points.Add(l1.transform);
        points.Add(l2.transform);

    }

    private void Update()
    {
        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        //get the next point tranform
        Transform goalPoints = points[nextID];
        //Flip fish
        if (goalPoints.transform.position.x > transform.position.x)
            transform.localScale = new Vector3((float)-0.06087505, (float)0.06087505, (float)0.06087505);
        else
            transform.localScale = new Vector3((float)0.06087505, (float)0.06087505, (float)0.06087505);
        //Move the enemy towards the goal points
        transform.position = Vector2.MoveTowards(transform.position, goalPoints.position, speed * Time.deltaTime);
        //check the distance
        if (Vector2.Distance(transform.position, goalPoints.position) < 1f)
        {
            if (nextID == points.Count - 1)
                idChangeValue = -1;

            if (nextID == 0)
                idChangeValue = 1;

            nextID += idChangeValue;
        }

    }
}
