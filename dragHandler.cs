using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class dragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	Vector3 startPosition;
	Transform startParent;

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		//cek posisi objek apakah ada di posisi tujuan apa enggak, kalo enggak balikin ke startPosition

		if (transform.parent != startParent) {
			transform.position = startPosition;
			GetComponent<CanvasGroup> ().blocksRaycasts = true;

		}
	}

	#endregion


}
