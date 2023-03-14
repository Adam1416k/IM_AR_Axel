using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Node
{
    private List<Neighbour> neighbours = new List<Neighbour>();
    private string id;
    private DijkstraNode dijkstraNode;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getId(){
        return id;
    }

    public List<Neighbour> getNeighbours()
    {
        return neighbours;
    }

    public void addId(string InputId){
        id = InputId;
    }

    public void addNeighbour(Neighbour newNeighbour){
        neighbours.Add(newNeighbour);
    }

    public void newDijkstraNode(){
        dijkstraNode = new DijkstraNode();
    }

    public DijkstraNode getDijkstraNode(){
        return dijkstraNode;
    }

}
