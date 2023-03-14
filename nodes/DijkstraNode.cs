using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DijkstraNode
{   
    public const int MaxValue = 2147483647;

    private Node prev = null;
    private int distance = MaxValue;
    private bool visited = false;

    public void updatePrev(Node prev){
        this.prev = prev;
    }

    public Node getPrev(){
        return prev;
    }

    public void uppdateDistance(int distance){
        this.distance = distance;
    }

    public int getDistance(){
        return distance;
    }

    public void visited(){
        visited = true;
    }

    public bool getVisited(){
        return visited;
    }

}
