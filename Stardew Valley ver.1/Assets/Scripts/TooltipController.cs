using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Tooltip tooltip;

    public void OnPointerEnter(PointerEventData eventData)
    {
        InventoryButton slot = GetItemAtMousePosition();
        int index = slot.myIndex;

        Item item = FindObjectOfType<ItemPanel>().inventory.slots[index].item;

        if (slot != null && item != null)
        {
            tooltip.gameObject.SetActive(true);
            tooltip.SetupTooltip(item.Name, item.itemDesc);
        }
        else
        {
            tooltip.gameObject.SetActive(false);
        }

    }

    // 마우스 위치에 있는 아이템 슬롯을 검색
    private InventoryButton GetItemAtMousePosition()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> result = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, result);

        foreach (RaycastResult raycastResult in result)
        {
            InventoryButton itemslot = raycastResult.gameObject.GetComponent<InventoryButton>();
            if (itemslot != null)
            {
                return itemslot;
            }
        }

        return null;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.gameObject.SetActive(false);
    }
}