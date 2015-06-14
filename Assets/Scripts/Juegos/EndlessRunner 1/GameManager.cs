using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Player player = null;
    public EnemiesController enemies = null;
    public GameObject contenedor = null;
    private GameObject anterior = null;
    public Image background = null;
    public Text score = null;
    public Text best = null;
    public GameObject gameOver = null;
    public int points = 0;
    public GameObject game = null;
    //prueba
    public Sprite[] pla = null;
    public Sprite backg = null;
    public Sprite[] enes = null;
    public bool end = false;

    void Start()
    {
        start(null, pla, enes, backg);
    }

    public void start(GameObject anterior, Sprite[] player, Sprite[] enemies,Sprite background)
    {
        if (PlayerPrefs.HasKey("Score1"))
        {
            best.text = "Best: " + PlayerPrefs.GetInt("Score1");
        }
        else
        {
            best.text = "";
        }    
        this.pla = player;
        this.backg = background;
        this.enes = enemies;
        contenedor.SetActive(true);
        this.player.setSprite(player,this);
        this.enemies.start(enemies);
        this.background.sprite = background;
        this.anterior = anterior;
        //anterior.SetActive(false);
        StartCoroutine(scores());
    }

    public void back()
    {
        Debug.Log("asd");
        Application.LoadLevel(Application.loadedLevelName);
        /*anterior.SetActive(true);
        contenedor.SetActive(false);*/
    }

    IEnumerator scores()
    {
        while (!end)
        {
            this.score.text = "Score: " + points;
            yield return new WaitForSeconds(0.4f);
            points++;
        }
    }

    public void lose()
    {
        gameOver.SetActive(true);
        end = true;
        player.gameObject.SetActive(false);
        if ((PlayerPrefs.HasKey("Score1") && PlayerPrefs.GetInt("Score1") < points) || !PlayerPrefs.HasKey("Score1"))
        {
             PlayerPrefs.SetInt("Score1", points);
        }

        
    }

    public void restart()
    {
        GameObject game = (GameObject)Instantiate(Resources.Load<GameObject>("Prefabs/Juegos/Runner 1/Runner 1"));
        game.GetComponent<GameManager>().start(this.anterior,pla,enes,backg) ;
        Destroy(gameObject);
    }
}
