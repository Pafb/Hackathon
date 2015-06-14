using UnityEngine;
using System.Collections;

public class Link : MonoBehaviour {

    public void link(string link)
    {
        Application.OpenURL(link);
    }
}
