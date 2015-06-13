using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UrlImporter : MonoBehaviour {
    bool terminado;
    

    public void urlToSprite(string path, Image imagen) {
        Debug.Log(path);
        StartCoroutine(cargarImagen(path, (value) => {
                                                          if (value) { 
                                                              Debug.Log("entro"); 
                                                              imagen.sprite = value; 
                                                          }
                                                     }));    
    }

    IEnumerator cargarImagen(string path,System.Action<Sprite> newSprite){
        WWW www = new WWW(path);
        yield return www;
        if (www.error == null)
        {
            Texture2D texture = new Texture2D(1024, 1024, TextureFormat.RGB565, false);
            www.LoadImageIntoTexture(texture);
            newSprite(Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f)));
            Debug.Log("imagen cargada con éxito");
            
        }
        else {
            this.terminado = true;
            Debug.Log("error cargando la imagen ");
            newSprite(null);
        }
        
    }
}
