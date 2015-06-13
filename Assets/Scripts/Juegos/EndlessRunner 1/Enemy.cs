using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    private float speed = 0.06f;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-speed,0f,0f);
        if(transform.localPosition.x < -10f )
        {
            Destroy(gameObject);
        }
	}

    public void setSpeed(float speed)
    {
        this.speed = speed; ;
    }
}
