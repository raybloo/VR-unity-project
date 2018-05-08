using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScroll : MonoBehaviour {

    public Vector3 speed;
    private bool[] children;
	// Use this for initialization
	void Start () {
        children = new bool[transform.childCount];
        for(int i = 0; i<3; i++) {
            children[i] = true;
        }
        speed = Vector3.back*3;
	}
	
	// Update is called once per frame
	void Update () {

        //transform.position += speed;
        for(int i = 0; i<transform.childCount; i++) {
            if(children[i]) {
                Vector3 previous_pos = transform.GetChild(i).position;
                if(previous_pos.z <= -750) {
                    previous_pos = new Vector3(previous_pos.x, previous_pos.y, previous_pos.z+1500);
                }
                transform.GetChild(i).SetPositionAndRotation(previous_pos + speed, transform.GetChild(i).rotation);
            }
        }
		 //update positions of selected
         //check for edge case
         //if edge update selection
	}
}
