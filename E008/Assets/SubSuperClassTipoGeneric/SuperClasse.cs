using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperClasse {

	public float superFloat;

	public SuperClasse(float vsuperFloat){
		superFloat = vsuperFloat;
	}

	public float MyMethod(float anotherFloat){
		return superFloat + anotherFloat;
	}
		
}
