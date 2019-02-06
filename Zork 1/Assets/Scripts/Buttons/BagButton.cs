using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BagButton : MonoBehaviour, IPointerClickHandler
{
    private Bag bag;

    [SerializeField]
    private Sprite full, empty;

    public Bag MyBag
    {
        get => bag;
        set
        {
            bag = value;
        }
    }
    //click to open and close inventory
    public void OnPointerClick(PointerEventData eventData)
    {
        if (bag != null)
        {
            if (bag.Clicked)
            {
                GetComponent<Image>().sprite = full;
            }
            else if (bag.Clicked == false)
            {
                GetComponent<Image>().sprite = empty;
            }
            bag.MyBagScript.OpenClose(bag);
        }
    }
}
