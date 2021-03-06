﻿using UnityEngine;
using Route;

/// <summary>
/// Used as a sample Route
/// </summary>
public class RouteInvoker : MonoBehaviour {

    public GameObject startNode;
    public GameObject endNode;

	// Use this for initialization
	void Start () {
        RouteResult result = Router.Route(startNode.GetComponent<Node>(), endNode.GetComponent<Node>());
        foreach (Node n in result.nodes) {
            n.isInShortestPath = true;
        }
	}
}
