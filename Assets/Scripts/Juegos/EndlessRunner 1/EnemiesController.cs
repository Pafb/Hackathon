using UnityEngine;
using System.Collections;

public class EnemiesController : MonoBehaviour {

    public GameObject enemy = null;
    private Sprite[] textures = null;


	// Use this for initialization
	void Start () {
        
        //StartCoroutine(generateEnemies());
	}

    public void start(Sprite[] textures)
    {
        this.textures = textures;
        StartCoroutine(generateEnemies());
    }


    public IEnumerator generateEnemies()
    {
        while(true)
        {
            int quantity = (int)Random.Range(1f,3.5f);
            for (int i = 0; i < quantity; ++i )
            {

                GameObject tmp =  (GameObject)Instantiate(enemy, Vector3.zero, new Quaternion());
                float width = tmp.GetComponent<SpriteRenderer>().sprite.bounds.size.x * 100;
                float height = tmp.GetComponent<SpriteRenderer>().sprite.bounds.size.y * 100;
                if(textures!= null)
                {
                    Sprite nuevo = textures[Random.Range(0, textures.Length)];
                    tmp.GetComponent<SpriteRenderer>().sprite = nuevo;
                    width = nuevo.bounds.size.x*100;
                    height = nuevo.bounds.size.y*100;
                }
                tmp.GetComponent<BoxCollider2D>().size = new Vector2(width/100f,height/100f);
                tmp.transform.localScale = new Vector2((55f / width), (55f / height));
                tmp.transform.SetParent(gameObject.transform);
                tmp.transform.localPosition = new Vector2(9f+(Random.Range(0.1f,0.3f)),Random.Range(-1f,1f)*3f);
            }

            yield return new WaitForSeconds(Random.Range(0.5f,1f));
        }
    }
}
