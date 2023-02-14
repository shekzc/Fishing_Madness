using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class FishMovement : MonoBehaviour
{
    public List<Transform> points;
    public int nextID = 0;

    int idChangeValue = 1;
    public float speed = 2;

    private void Reset()
    {
        Init();
    }

    void Init()
    {
        //Boxcloider Trigger
        GetComponent<BoxCollider2D>().isTrigger = true;

        //create Root object
        GameObject root = new GameObject(name + "_Root");

        //Reset Position of Root to enemy object
        root.transform.position = transform.position;

        transform.SetParent(root.transform);

        //create waypoint object
        GameObject waypoints = new GameObject("Waypoints");

        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = root.transform.position;

        //create two poitns
        GameObject p1 = new GameObject("Point1");
        p1.transform.SetParent(waypoints.transform);
        p1.transform.position = root.transform.position;

        GameObject p2 = new GameObject("Point2");
        p2.transform.SetParent(waypoints.transform);
        p2.transform.position = root.transform.position;

        //Init Points then add points
        points = new List<Transform>();
        points.Add(p1.transform);
        points.Add(p2.transform);

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
            transform.localScale = new Vector3((float)-0.03782384, (float)0.03782384, (float)0.03782384);
        else
            transform.localScale = new Vector3((float)0.03782384, (float)0.03782384, (float)0.03782384);
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
