using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCode : MonoBehaviour {

	public SubClasse subClasse;
	public SuperClasse superClasse;

	void Start () {
		subClasse = new SubClasse (2f, 1f);
		superClasse = new SuperClasse (4f);
		float novoFloat = subClasse.MyMethod (5f);
		print (novoFloat);

		novoFloat = subClasse.MetodoTipoGenerico<float> (subClasse.subFloat);
	}

}
