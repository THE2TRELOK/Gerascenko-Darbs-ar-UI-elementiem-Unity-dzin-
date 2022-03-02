using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour {

	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject garums;
	public GameObject platums;


	public void izkritosais(int skaitlis){
		if (skaitlis == 0) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
		}
		if (skaitlis == 1) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		}

	}
	public void Platums(){
		float sakVertiba = platums.GetComponent<Slider>().value;
		float sakGarums = garums.GetComponent<Slider>().value;
		mainigaisAttels.GetComponent <RectTransform>().sizeDelta = new Vector2 (110F * sakVertiba, 220F*sakGarums);
	}
	public void Garums(){
		float sakVertiba = platums.GetComponent<Slider>().value;
		float sakGarums = garums.GetComponent<Slider>().value;
		mainigaisAttels.GetComponent <RectTransform>().sizeDelta = new Vector2 (110F * sakVertiba, 220F*sakGarums);
	}
}