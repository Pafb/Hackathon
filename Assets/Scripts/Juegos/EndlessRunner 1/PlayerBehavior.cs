using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

    public GameObject player = null;
    

    void OnMouseDrag()
    {
        if(player != null)
        {

            Vector2 curScreenPoint = new Vector2(player.transform.localPosition.x, Input.mousePosition.y);
            Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            if(curPosition.y <3 && curPosition.y > -3)
            {   curPosition.x = player.transform.localPosition.x;
                player.transform.localPosition = curPosition;
            }
        }
    }
}
