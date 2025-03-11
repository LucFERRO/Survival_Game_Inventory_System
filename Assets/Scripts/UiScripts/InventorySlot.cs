using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    //public Color baseColor;
    private void Start()
    {
        //baseColor = transform.GetComponent<Image>().color;
        //GetColorFromChild();
    }
    //private void OnTransformChildrenChanged()
    //{
    //    GetColorFromChild();
    //}

    //private void GetColorFromChild()
    //{
    //    if (transform.childCount != 0)
    //    {
    //    }
    //}
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            eventData.pointerDrag.GetComponent<DraggableItem>().parentAfterDrag = transform;
        }
    }
}