using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {

	public GameObject Bins;
	public GameObject Lacis;
	public GameObject Tante;
	public GameObject Masina;

	public void BinaAttelosana(bool vertiba){
		Bins.SetActive (vertiba);
	}
	public void LacisaAttelosana(bool vertiba){
		Lacis.SetActive (vertiba);
	}
	public void TantesAttelosana(bool vertiba){
		Tante.SetActive (vertiba);
	}
	public void MasinasAttelosana(bool vertiba){
		Masina.SetActive (vertiba);
	}

	public void paKreisiBins(){
		Bins.transform.localScale = new Vector2 (1, 1);

	}
	public void paLabiBins(){
		Bins.transform.localScale = new Vector2 (-1, 1);

	}

}
