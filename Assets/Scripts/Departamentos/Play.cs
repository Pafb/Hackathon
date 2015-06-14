using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

    public Sprite[] pla = null;
    public Sprite backg = null;
    public Sprite[] enes = null;
    public GameObject game = null;
    public GameObject a;
    public GameObject departamento = null;

    public void play()
    {
        a = Instantiate(game);
        a.GetComponent<GameManager>().start(departamento, pla, enes, backg);
    }
}
