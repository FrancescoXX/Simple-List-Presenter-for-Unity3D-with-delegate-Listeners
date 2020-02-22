using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemManager : MonoBehaviour {

    public Transform placeholder; // Content placeholder to Instantiate gameobjects
    public GameObject rowItem; // Unity prefab to Instantiate

    private Item[] items;
    private List<GameObject> gameObjects = new List<GameObject>(); // Reference to Gameobjects to destroy them

    private void OnEnable() {
        ClearGos();

        //Initialize Items Array, fetch from API, ...
        items = new Item[3] {
            new Item(3, "Giulia", 1000),
            new Item(5, "Francesco", 10),
            new Item(7, "Robert", 500),
        };

        for (int i = 0; i < items.Length; i++) {
            ShowItemForSlot(i);
        }
    }

    private void ShowItemForSlot(int i) {
        Item item = items[i];

        var go = Instantiate(rowItem, placeholder.transform)as GameObject;
        ItemListRowVM row = go.GetComponent<ItemListRowVM>();

        row.SetUi(item);

        //Add Delegates to row item buttons
        row.removeButton.onClick.AddListener(RemoveItem(item));
        gameObjects.Add(go);
    }

    private UnityAction RemoveItem(Item item) => delegate {
        print("Remove item " + item.name);
    };

    //Clean Up
    private void ClearGos() {
        foreach (var go in gameObjects)Destroy(go);
        gameObjects.Clear();
    }
}