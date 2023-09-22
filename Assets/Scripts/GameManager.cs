using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static UnityEditor.Progress;

public class ItemSlot
{
    public ItemData item;
    public int quantity;
}
public class GameManager : MonoBehaviour
{
    public ItemSlot[] slots;

    public GameObject inventoryWindow;
    public GameObject infoWindow;
    public GameObject statusWindow;
    [SerializeField]
    List<ItemDataConsumable> itemList;

    [Header("Selected Item")]
    private ItemSlot selectedItem;
    private int selectedItemIndex;
    //public TextMeshProUGUI selectedItemName;
    //public TextMeshProUGUI selectedItemDescription;
    //public TextMeshProUGUI selectedItemStatNames;
    //public TextMeshProUGUI selectedItemStatValues;
    //public GameObject useButton;
    //public GameObject equipButton;
    //public GameObject unEquipButton;
    //public GameObject dropButton;

    [Header("Events")]
    public UnityEvent onOpenInventory;
    public UnityEvent onCloseInventory;

    public static GameManager instance;


    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        inventoryWindow.SetActive(false);
        statusWindow.SetActive(false);
    }

    public void OnStatus()
    {
        infoWindow.SetActive(false);
        statusWindow.SetActive(true);
    }
    public void OnInventory()
    {
        infoWindow.SetActive(false);
        inventoryWindow.SetActive(true);
    }
    public void BackButton()
    {
        statusWindow.SetActive(false);
        inventoryWindow.SetActive(false);
        infoWindow.SetActive(true);
    }
    //public void OnInventoryButton(InputAction.CallbackContext callbackContext)
    //{
    //    if (callbackContext.phase == InputActionPhase.Started)
    //    {
    //        Toggle();
    //    }
    //}
    //public void Toggle()
    //{
    //    if (inventoryWindow.activeInHierarchy)
    //    {
    //        inventoryWindow.SetActive(false);
    //        onCloseInventory?.Invoke();
    //    }
    //    else
    //    {
    //        inventoryWindow.SetActive(true);
    //        onOpenInventory?.Invoke();
    //    }
    //}

    //public bool IsOpen()
    //{
    //    return inventoryWindow.activeInHierarchy;
    //}
    //public void AddItem(ItemData item)
    //{
    //    if (item.canStack)
    //    {
    //        ItemSlot slotToStackTo = GetItemStack(item);
    //        if (slotToStackTo != null)
    //        {
    //            slotToStackTo.quantity++;
    //            UpdateUI();
    //            return;
    //        }
    //    }

    //    ItemSlot emptySlot = GetEmptySlot();

    //    if (emptySlot != null)
    //    {
    //        emptySlot.item = item;
    //        emptySlot.quantity = 1;
    //        UpdateUI();
    //        return;
    //    }

    //    ThrowItem(item);
    //}

    //void ThrowItem(ItemData item)
    //{

    //}

    //void UpdateUI()
    //{

    //}

    //ItemSlot GetItemStack(ItemData item)
    //{
    //    for (int i = 0; i < slots.Length; i++)
    //    {
    //        if (slots[i].item == item && slots[i].quantity < item.maxStackAmount)
    //            return slots[i];
    //    }
    //    return null;
    //}

    //ItemSlot GetEmptySlot()
    //{
    //    for (int i = 0; i < slots.Length; i++)
    //    {
    //        if (slots[i].item == null)
    //            return slots[i];
    //    }
    //    return null;
    //}

    //public void SelectItem(int index)
    //{
    //    if (slots[index].item == null)
    //        return;

    //    selectedItem = slots[index];
    //    selectedItemIndex = index;

    //    selectedItemName.text = selectedItem.item.displayName;
    //    selectedItemDescription.text = selectedItem.item.description;

    //    selectedItemStatNames.text = string.Empty;
    //    selectedItemStatValues.text = string.Empty;

    //    for (int i = 0; i < selectedItem.item.consumables.Length; i++)
    //    {
    //        selectedItemStatNames.text += selectedItem.item.consumables[i].type.ToString() + "\n";
    //        selectedItemStatValues.text += selectedItem.item.consumables[i].value.ToString() + "\n";
    //    }

    //}
    //private void ClearSeletcItemWindow()
    //{
    //    selectedItem = null;
    //    selectedItemName.text = string.Empty;
    //    selectedItemDescription.text = string.Empty;

    //    selectedItemStatNames.text = string.Empty;
    //    selectedItemStatValues.text = string.Empty;

    //    useButton.SetActive(false);
    //    equipButton.SetActive(false);
    //    unEquipButton.SetActive(false);
    //    dropButton.SetActive(false);
    //}

}
