using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public bool kill = false;
    public GameManager manager = null;

    void Start()
    {
        float width = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x * 100;
        float height = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.y * 100;
        gameObject.transform.localScale = new Vector2((50f / width), (50f / height));
        
    }

    public void setSprite(Sprite[] player,GameManager game )
    {
        this.manager = game;
        StartCoroutine(animacion(player));
        
        StartCoroutine(killer());
    }

    IEnumerator animacion(Sprite[] player)
    {
        int count = 0;
        gameObject.transform.localScale = new Vector2((50f / player[count].bounds.size.x/100), (50f / player[count].bounds.size.y/100));
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(player[count].bounds.size.x, player[count].bounds.size.y);
            
        while (true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = player[count];
            yield return new WaitForSeconds(0.3f);
            count = (count + 1) % player.Length;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Finish") && kill)
        {
            manager.lose();
        }
    }

    IEnumerator killer()
    {
        yield return new WaitForSeconds(0.5f);
        kill = true;
    }
}
