using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScript : MonoBehaviour {

	Mesh mesh;

	Vector3[] Vertices = new Vector3[4];


	void Start () {
		//mesh = new Mesh ();
		//GetComponent<MeshFilter> () = mesh;
		MeshFilter meshFilter = GetComponent < MeshFilter >();
		mesh = meshFilter.mesh;


		Vertices [0] = new Vector3 (0, 0, 0);
		Vertices [1] = new Vector3 (1, 0, 0);
		Vertices [2] = new Vector3 (1, -1, 0);
		Vertices [3] = new Vector3 (0, -1, 0);

		mesh.vertices = Vertices;

		//int[] Triangles = new int[3] {0,1,2} ; //triangulo
		int[] Triangles = new int[6] {0,1,2,0,2,3} ; //quadrado

		mesh.triangles = Triangles;

		incremento = 1f / 30f;
        
	}
	
	float t, incremento;

	void Update () {

		t += incremento;
		if (t > (2 * Mathf.PI))
			t = 0;

		Vertices[0] = new Vector3( Mathf.Cos(t+Mathf.PI / 2) , Mathf.Sin(t + Mathf.PI/2) , 0 ); //vertice zero circulando

		Vertices [2] = t <= Mathf.PI ? new Vector3 (t, -t, 0) : (Vertices[2] - new Vector3 (incremento,-incremento,0)) ;
        // vertice 2 andando numa reta;

		mesh.vertices = Vertices;
	}
}
