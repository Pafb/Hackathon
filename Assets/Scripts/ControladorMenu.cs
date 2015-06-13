using UnityEngine;
using System.Collections;

public class ControladorMenu : MonoBehaviour {

    public GameObject tienda;
    public GameObject creditos;
    public GameObject administrar;
    public GameObject mainMenu;

    public int estado; 

    void Start() {
        estado = 0;
    }

    public void onTiendaClicked() {
        estado = 1;
        this.mainMenu.SetActive(false);
        this.tienda.SetActive(true);
    }

    public void onCreditosClicked() {
        estado = 3;
        this.mainMenu.SetActive(false);
        this.creditos.SetActive(true);
    }

    public void onAdministrarClicked() {
        estado = 2;
        this.mainMenu.SetActive(false);
        this.administrar.SetActive(true);
    }

    public void onVolverClicked() {
        switch (estado) {
            case 0:
                Application.Quit();
                break;
            case 1:
                this.estado = 0;
                this.tienda.SetActive(false);
                this.mainMenu.SetActive(true);
                break;
            case 2:
                this.estado = 0;
                this.administrar.SetActive(false);
                this.mainMenu.SetActive(true);    
                break;
            case 3:
                this.estado = 0;
                this.creditos.SetActive(false);
                this.mainMenu.SetActive(true);
                break;
        }

    }

}
