using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Node : MonoBehaviour
{
    private List<Neighbour> neighbours = new List<Neighbour>();
    private string id;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
