using UnityEngine;
using UnityEngine.UI;

//Item ViewModel
public class ItemListRowVM : MonoBehaviour {

    public Text idText;
    public Text titleText;
    public Text recordText;
    public Button removeButton; // Delegate added by the Manager

    public void SetUi(Item item) {
        idText.text = item.id.ToString();
        titleText.text = item.name;
        recordText.text = item.record.ToString();
    }
}