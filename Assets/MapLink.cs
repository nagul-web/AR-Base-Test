using UnityEngine;

public class MapLink : MonoBehaviour
{
    public string locationURL = "https://maps.app.goo.gl/P3s3s244R2BozXU89"; // I put a placeholder KFC link here!

    public void OpenMap()
    {
        Application.OpenURL(locationURL);
    }
}