using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

	public GameObject Bins;
	public GameObject Lacis;
	public GameObject Tante;
	public GameObject Masina;
	public GameObject attelaTuretajs;
	public Sprite[] atteluMasivs;
	public GameObject slaideris;


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
	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image> ().sprite = atteluMasivs [0];
		else if (skaitlis == 1)
			attelaTuretajs.GetComponent<Image> ().sprite = atteluMasivs [1];
		else if (skaitlis == 2)
			attelaTuretajs.GetComponent<Image> ().sprite = atteluMasivs [2];
	}

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1F*pasreizejaVertiba,1F*pasreizejaVertiba);
	}
}
