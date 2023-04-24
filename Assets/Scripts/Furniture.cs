using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    Camera cm;
    GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.instance;
        cm = GameObject.FindAnyObjectByType<Camera>();
    }
    private void OnMouseDrag()
    {
        if (cm == null) return;
        Vector3 pos = cm.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector3.Lerp(transform.position, new Vector3(pos.x, pos.y, transform.position.z), Time.deltaTime * 5f);
        ClapmPostion();
    }

    private void ClapmPostion()
    {
        Vector3 currentRoomSize = gameManager.CurrentRoomSize;
        float maxX = currentRoomSize.x / 2f - transform.localScale.x / 2f;
        float minX = -currentRoomSize.x / 2f + transform.localScale.x / 2f;
        float maxY = currentRoomSize.y / 2f - transform.localScale.y / 2f;
        float minY = -currentRoomSize.y / 2f + transform.localScale.y / 2f;

        float x = Mathf.Clamp(transform.position.x, minX, maxX);
        float y = Mathf.Clamp(transform.position.y, minY, maxY);

        transform.position = new Vector3(x, y, transform.position.z);

    }
}
