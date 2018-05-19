using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnoCard : MonoBehaviour {

    public bool isBack = true;

    public NumberType numberType = NumberType.N0;

    public ColorType colorType = ColorType.b;

    /// <summary>
    /// 刷新图片
    /// </summary>
    public void ReloadSprite()
    {
        Debug.Log(numberType.ToString());
        
    }



    // Use this for initialization
    void Start () {
        ReloadSprite();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
