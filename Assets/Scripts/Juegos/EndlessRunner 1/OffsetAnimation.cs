using UnityEngine;
using System.Collections;

public class OffsetAnimation : MonoBehaviour {
    static string mainTexture = "_MainTex";

    public float speed = 0.05f  ;

    public bool stop = false;

    void Update()
    {
        if (!stop)
        {
           
           //renderer.material.SetTextureOffset(mainTexture, new Vector2(Mathf.Repeat(1 * speed, 1), 0));
        }
    }
}
