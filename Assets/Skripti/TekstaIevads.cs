using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaIevads : MonoBehaviour {
	public class VardaParadisana : MonoBehaviour{
	
	}
	public string teksts;
	public string vecums;
	public GameObject ievads2;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	public void uzglabaTekstu(){
		teksts = ievadesLauks.GetComponent<Text>().text;
		vecums = ievads2.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text> ().text = "Varonim " +teksts.ToUpper()+", "+vecums+" gadi";
	}
}
