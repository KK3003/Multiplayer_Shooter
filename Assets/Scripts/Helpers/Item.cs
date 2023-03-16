using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public GameObject itemGameObject;
    public ItemInformation itemInfo;

    public abstract void Use(); 
}
