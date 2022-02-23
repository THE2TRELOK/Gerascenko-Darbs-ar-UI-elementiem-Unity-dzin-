using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

	public GameObject lade1;
	public GameObject lade2;
	public GameObject lade3;
	public GameObject lade4;
	public GameObject kivere1;
	public GameObject kivere2;
	public GameObject kivere3;
	public GameObject kivere4;
	public GameObject bikses1;
	public GameObject bikses2;
	public GameObject bikses3;
	public GameObject bikses4;
	public GameObject botes1;
	public GameObject botes2;
	public GameObject botes3;
	public GameObject botes4;

	public void LadesAttelosana(bool vertiba){
		lade1.SetActive (vertiba);
		lade2.SetActive (vertiba);
		lade3.SetActive (vertiba);
		lade4.SetActive (vertiba);
	}
	public void KiveresAttelosana(bool vertiba){
		kivere1.SetActive (vertiba);
		kivere2.SetActive (vertiba);
		kivere3.SetActive (vertiba);
		kivere4.SetActive (vertiba);
	}
	public void Bikseslosana(bool vertiba){
		bikses1.SetActive (vertiba);
		bikses2.SetActive (vertiba);
		bikses3.SetActive (vertiba);
		bikses4.SetActive (vertiba);
	}
	public void Boteslosana(bool vertiba){
		botes1.SetActive (vertiba);
		botes2.SetActive (vertiba);
		botes3.SetActive (vertiba);
		botes4.SetActive (vertiba);
}
}