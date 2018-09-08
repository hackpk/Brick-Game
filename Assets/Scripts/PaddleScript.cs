using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenUnits = 16f;
	
	// Update is called once per frame
	void Update () {
        float mousePosinUnits = Input.mousePosition.x / Screen.width * screenUnits;

        Vector2 mousePos = new Vector2 (transform.position.x, transform.position.y);

        mousePos.x = Mathf.Clamp(mousePosinUnits,minX,maxX);

        transform.position = mousePos;
		
	}
}
