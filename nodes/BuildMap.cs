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
        
       foreach (string line in map)
       {
            string[] devidedComands = line.Split('[');
            Node node = new Node();
            foreach (string comand in devidedComands)
            {   
                if(comand.Length != 0){

                    switch (comand[0])
                    {
                    case 'R':
                        Debug.Log(comand.Split('-',']')[1]);
                        //node.addId()
                    break;
                    default:
                        Debug.Log("do");
                    break;
                    }
                }
                
            }
       }
        
    }

}
