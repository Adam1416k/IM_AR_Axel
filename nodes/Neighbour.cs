using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbour
{
        public int distance;
        public string direction;
        public Node neighbourNode;
        
        
        public Neighbour(int distanceIn, string directionIn, Node neighbourNodeIn){
                distance = distanceIn;
                direction = directionIn;
                neighbourNode = neighbourNodeIn;
        }
}
