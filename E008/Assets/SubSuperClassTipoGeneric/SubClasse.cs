using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SubClasse : SuperClasse {

	public float subFloat;

	public SubClasse (float vsubFloat, float vsuperFloat): base(vsuperFloat)
	{
		subFloat = vsubFloat;
	}

	public T MetodoTipoGenerico <T> (T parametroGenerico){
	
		MonoBehaviour.print (parametroGenerico);

	
		return parametroGenerico;

	}
		
}
