using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler{

	Transform parentToReturnTo = null;

	public void OnBeginDrag(PointerEventData eventData){
		
		Debug.Log (" begin dragged"); 
		parentToReturnTo = this.transform.parent;

		this.transform.SetParent(this.transform.parent.parent);
	}

	public void OnDrag(PointerEventData eventData){
		Debug.Log ("Dragging");
		this.transform.position = eventData.position;
	}
	public void OnEndDrag(PointerEventData eventData){
		Debug.Log ("End drag");
		this.transform.parent = parentToReturnTo;
	}

}
