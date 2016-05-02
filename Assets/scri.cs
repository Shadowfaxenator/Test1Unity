using UnityEngine;
using System.Collections;
[SelectionBase]
public class scri : MonoBehaviour {


    [ContextMenuItem("Reset", "ResetBiography")]
    [Tooltip("Health value between 0 and 100.")]
    public string playerBiography = "";
    void ResetBiography() {
        playerBiography = "";
    }



void Start () {


      
   
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
