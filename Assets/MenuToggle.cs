using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    // This creates an empty slot in Unity where we will drop your SocialFolder
    public GameObject folder; 

    // This is the light switch! It turns the folder ON if it's off, and OFF if it's on.
    public void ToggleMenu()
    {
        folder.SetActive(!folder.activeSelf);
    }
}