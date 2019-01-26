using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickGenerator : MonoBehaviour {
	[SerializeField] GameObject wall ;
		
	public void gimmicgenerator(){
        Vector3 mousePointInScreen = Input.mousePosition;
            mousePointInScreen.z+=10.0f;
            
            
            
		
		Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
		
		Vector3 spawnPosition = new Vector3(mousePointInWorld.x, 0.5f, mousePointInWorld.z);
		
		
		Instantiate(wall, spawnPosition,Quaternion.identity);
		
	}
}
