using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorGreen : MonoBehaviour {
    public SpriteRenderer character;
    public Sprite Lab2Chara3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("clicked");
        character.sprite = Lab2Chara3;
    }
}
