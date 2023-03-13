using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public string start;
    public string end;
    // Start is called before the first frame update
    void Start()
    {
        Node startNode = null;
        Node endNode = null;
        Buildmap map = new Buildmap();
        List<Node> graph = map.getNodes();
        foreach (Node node in graph)
        {
            if(node.getId() == start)
            {
                startNode= node;
            }else if(node.getId() == end)
            {
                endNode= node;
            }
        }
        new searchGreedy(startNode, endNode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
