using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Carrousel : MonoBehaviour {

    public void cargarCarrousel(string sprites)
    {
        Sprite[] fondos = Resources.LoadAll<Sprite>(sprites);
        Debug.Log(fondos.Length);
        float ancho = Resources.Load<GameObject>("Prefabs/ImagenEnBlanco").GetComponent<RectTransform>().rect.width + 10f;
        
        GameObject contenedor = gameObject.transform.GetChild(0).FindChild("Contenido").gameObject;
        contenedor.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho * fondos.Length, 120f);
        for (int i = 0; i < fondos.Length; i++)
        {
            GameObject elementoDelCarousel = Instantiate(Resources.Load<GameObject>("Prefabs/ImagenEnBlanco"));
            elementoDelCarousel.GetComponent<Image>().sprite = fondos[i];
            elementoDelCarousel.transform.SetParent(gameObject.transform.GetChild(0).FindChild("Contenido"));
            elementoDelCarousel.transform.localPosition = new Vector3(ancho * i, 0f, 0f);
        }
    }
}
