using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile {
	public GameObject tile;
	private Unit unit;
	float xfactor = 0.882f;
	float zfactor = 0.764f;
	float xcorrection = 0.441f;
	public Vector3 position3D;

	public GridTile(Vector2 pos){
		float xPos = pos.x*xfactor;
		float zPos = pos.y*zfactor;
		if (pos.y%2 == 1){
			xPos += xcorrection;
		}
		position3D = new Vector3(xPos, 0, zPos);
		unit = null;
	}

	bool hasObject(){
		return (unit == null);
	}
	public void setUnit(){
		unit = new Unit(position3D);
	}
	public Unit getUnit(){
		return unit;
	}

	public void setGrass(){
		GameObject tileObject = GameObject.FindGameObjectWithTag ("Grass");;
		tile = GameObject.Instantiate(tileObject, position3D, Quaternion.Euler(new Vector3(-90, 0, 0)));
	}
}
