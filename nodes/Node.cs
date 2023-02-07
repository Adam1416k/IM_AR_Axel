using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Node : MonoBehaviour
{

    public List<Node> neighbourNodes;
    public int[] distance;
    private List<Neighbour> neighbours = new List<Neighbour>();
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        int r = 0;
        foreach (Node I in neighbourNodes)
        {   
            Neighbour temp = new Neighbour();
            temp.distance = distance[r];
            temp.neighbourNode = I;
            neighbours.Add(temp);
            r++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Neighbour> getNeighbours()
    {
        return neighbours;
    }
}
