using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections.Generic;


public class Dijkstras
{   

    private Queue<Node> priority = new Queue<Node>();
    private Node start;
    private Node end;


    public Dijkstras(Node start, Node end){
        this.start = start;
        this.end = end;
        searsh(this.start);
    }

    private searsh(Node node){
       List<Neighbour> = node.getNeighbours();
    }

}
