﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    // todo stop exposing these or make readonly
    [SerializeField] Vector2Int gridPos;
    [SerializeField] bool blocked = false;
    [SerializeField] bool explored = false;

	// Use this for initialization
	void Start () {
        gridPos.x = Mathf.RoundToInt(transform.position.x / 10);
        gridPos.y = Mathf.RoundToInt(transform.position.z / 10);
	}
	
    public void SetBlocked()
    {
        blocked = false;
    }

    public Vector2Int GetGridPos()
    {
        return gridPos;
    }
}
