using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoScript : MonoBehaviour {

	public Mesh mesh;

	void OnDrawGizmos(){
		Gizmos.color = Color.black;

		//Gizmos.DrawCube (Vector3.zero, Vector3.one); //DrawCube
		Gizmos.DrawMesh (mesh);
	}


}
