using UnityEngine;
using System.Collections;

public class DrawButton : MonoBehaviour {

	public float xPos;
	public float yPos;
	public float xSize;
	public float ySize;
	public Texture playTexture;

	void OnGUI(){
		if (GUI.Button(new Rect(xPos,yPos,xSize,ySize),playTexture)){
			Application.LoadLevel(1);
		}
	}
}
