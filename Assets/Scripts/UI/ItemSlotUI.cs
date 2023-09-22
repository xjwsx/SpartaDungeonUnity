using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Image icon;
    public Image equip;
    private ItemSlot curSlot;
    private Outline outline;

    public int index;
    public bool equipped;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    public void Set(ItemSlot slot)
    {
        curSlot = slot;
        icon.sprite = slot.item.icon;
        icon.gameObject.SetActive(false);
        equip.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        //GameManager.instance.SelectItem(index);
    }
}
