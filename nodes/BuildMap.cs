
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMap : MonoBehaviour
{   
    private List<Node> graph = new List<Node>();

    void Start() {
        //read the file
        string[] mapString = System.IO.File.ReadAllLines(@"Assets\nodes\MapInfo.txt");
        buildGraph(mapString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void buildGraph(string[] map){
        
        //takes the string info frome the document and decods it
       foreach (string line in map)
       {    
            //takes the first line and removes the opening bracket
            string[] devidedComands = line.Split('[');

            
            foreach (string comand in devidedComands)
            {   
                //cheks for empty statments
                if(comand.Length != 0){
                    
                    //looks if its a new node or a conetion thats being handeld
                    switch (comand[0])
                    {
                    //A new node
                    case 'R':
                        //creates a new node and ads it to the list of nodes
                        Node node = new Node();
                        node.addId(comand.Split('-',']')[1]);
                        graph.Add(node);
                    break;
                    //a conection
                    case 'N':
                        string[] neigb = comand.Split('-',',',']');
                        
                    break;
                    default:
                        Debug.Log("do");
                    break;
                    }
                }
                
            }
       }
        
    }

    //adds neigburs to the nodes
    private void addNeigb(string[] number){
        Node first = null;
        Node secon = null;
        foreach (Node node in graph)
        {   
            //takes the two nodes that a conection is being created for
            if(node.getId() == number[1]){
                first = node;
            }else if(node.getId() == number[3]){
                secon = node;
            }
        }
        //adds the neigburs 6 is the distance and 2 and 4 the direction
        first.addNeighbour(new Neighbour(number[6], number[2], secon));
        secon.addNeighbour(new Neighbour(number[6], number[3], first));

    }

}
