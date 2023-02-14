using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Green_Fish : MonoBehaviour
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

        GameObject q1 = new GameObject("Point1");
        q1.transform.SetParent(waypoints.transform);
        q1.transform.position = root.transform.position;

        GameObject q2 = new GameObject("Points2");
        q2.transform.SetParent(waypoints.transform);
        q2.transform.position = root.transform.position;

        points = new List<Transform>();
        points.Add(q1.transform);
        points.Add(q2.transform);

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
            transform.localScale = new Vector3((float)-0.06630775, (float)0.06630775, (float)0.06630775);
        else
            transform.localScale = new Vector3((float)0.06630775, (float)0.06630775, (float)0.06630775);
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
