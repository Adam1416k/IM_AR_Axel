using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using static UnityEditor.PlayerSettings;

public class searchGreedy : MonoBehaviour
{
    public const int MaxValue = 2147483647;

    public Node start;
    public Node end;
    private List<Node> Visited = new List<Node>();
    private Stack<Node> path = new Stack<Node>();
    private Node next = null;
    List<Neighbour> nodeneigbhour;
    Node pos;
    int pathdistance = 0;
    // Start is called before the first frame update
    void Start()
    {
        pos = start;
        path.Push(pos);
    }

    // Update is called once per frame
    void Update()
    {   
            nodeneigbhour = pos.getNeighbours();
            if (pos != end)
            {
                int shortest = MaxValue;

                //findes closets neigbhore
                foreach (Neighbour neigb in nodeneigbhour)
                {

                    //loks if the node is alredy visited
                    if (!Visited.Contains(neigb.neighbourNode))
                    {   
                        //comperes distance frome the nodes found
                        if (neigb.distance < shortest)
                        {
                            next = neigb.neighbourNode;
                            shortest = neigb.distance;
                        }
                    }

                }

                //moves the pos
                if (next == null)
                {   
                    Visited.Add(pos);
                    path.Pop();
                    pos = path.Peek();
                    Debug.Log("stack poped");
                }
                else
                {
                    //move

                    Visited.Add(pos);
                    path.Push(pos);
                    pos = next;
                    pathdistance += shortest;


                }
                next = null;
            }
            else
            {
            }

    }

}

