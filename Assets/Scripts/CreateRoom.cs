using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoom : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public List<Vector3> roomPositions = new List<Vector3>();
    private void Start()
    {
        RoomCrate(new Vector3(7.25f, 5.1f));
    }
    public void RoomCrate(Vector3 size)
    {
        GameManager.instance.CurrentRoomSize=size;
        roomPositions.Add(new Vector3(-size.x / 2, -size.y / 2));
        roomPositions.Add(new Vector3(-size.x / 2, size.y / 2));
        roomPositions.Add(new Vector3(size.x / 2, size.y / 2));
        roomPositions.Add(new Vector3(size.x / 2, -size.y / 2));
        roomPositions.Add(new Vector3(-size.x / 2, -size.y / 2));

        lineRenderer.SetPositions(roomPositions.ToArray());
    }



}

