using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utility : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static Sprite LoadResourcesImage(string path2, string path1 = "Textures/")
    {
        string pathAll = path1 + path2;
        Sprite sprite = Resources.Load<Sprite>(pathAll);
        return sprite;
    }
}
