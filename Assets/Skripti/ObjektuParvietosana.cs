
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private RectTransform transLogs;
	public Canvas Canva;

	void Start(){
		transLogs = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikškis uz objekta!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts tiek pārvietots!");
		transLogs.anchoredPosition += notikums.delta / Canva.scaleFactor;	
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pabeigta objekta pārvietošana!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta pārvietošana!");
	}
}
