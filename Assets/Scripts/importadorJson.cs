using UnityEngine;
using System.Collections;
using SimpleJSON;

public class importadorJson : MonoBehaviour {
	
	ManejadorJson k;
	public GameObject antes;
	public string apartamento;
	string[] accesorios;
	string[] obstaculos;
	Sprite[] acc1;
	Sprite[] obs1;
	string json;
	
	void Start(){
		//k = this.GetComponent<ManejadorJson>();
		//testLlenarJSON();
	}
	/*
	void testLlenarJSON(){
		
		
		k.crearDepartamento("Gatadas","gato1","gato1.jpg");
		k.crearJuego("Gatadas","Pollitos en fuga", "Huyendo.jpg");
		k.annadirObstaculo("Gatadas","pidras");
		k.annadirObstaculo("Gatadas","tortugas");
		k.annadirObstaculo("Gatadas","porte y la vara");
		k.annadirAccesorio("Gatadas","gotas");
		k.annadirAccesorio("Gatadas","gatos");
		k.annadirAccesorio("Gatadas","jardines");
		k.annadirAccesorio("Gatadas","tenedores");
		k.annadirAccesorio("Gatadas","cucharas");
		//k.printJSON();
		
		json=k.obtenerJSON();
		apartamento = "Gatadas";
		separarJson();
	}*/
	
	void meterJson(string jsonEntrante){
		json=jsonEntrante;
		separarJson();
	}
	
	void separarJson(){
		string fondo;
		//Debug.Log(json);
		
		var N = JSONNode.Parse(json);
		Debug.Log(N.ToString(""));
		int x1;
		int x2;
		x1 =N[apartamento]["juego"]["numAccesorios"].AsInt;
		x2 =N[apartamento]["juego"]["numObstaculos"].AsInt;
		
		acc1= new Sprite[x1];
		obs1= new Sprite[x2];
		Sprite fondoDibujo;
		
		accesorios = new string[x1];
		obstaculos = new string[x2];
		
		Debug.Log("x1 " + x1);
		Debug.Log("Ok mae, esta es la vara: obstaculos[x]");
		for (int x=0;x<x2;++x){
			obstaculos[x]=N[apartamento]["juego"]["obstaculos"][x];
			Debug.Log("obstaculos[x] "+obstaculos[x]);
			obs1[x]=(Sprite) Resources.Load(obstaculos[x]);
		}
		for (int x=0;x<x1;++x){
			accesorios[x]=N[apartamento]["juego"]["Accesorios"][x];
			Debug.Log("accesorios[x] "+accesorios[x]);
			acc1[x]=(Sprite) Resources.Load(accesorios[x]);
		}
		fondo=N[apartamento]["juego"]["fondo"];
		fondoDibujo=(Sprite) Resources.Load(fondo);
		//test(antes,acc1,obs1,fondoDibujo);
		
	}
	
	void setJSON(string temp){
		json = temp;
	}
	
	void setApartamento(string apartamentoNueva){
		apartamento=apartamentoNueva;
	}
	
	string[] getProductos(string cat){
		var N = JSONNode.Parse(json);
		int valor;
		valor = N[apartamento]["categoria"][cat]["numProductos"].AsInt;
		string[] elems;
		elems= new string[valor];
		for(int x=0;x<valor;++x){
			elems[x]=N[apartamento]["categoria"][cat][x];
		}
		return elems;
	}
	

	//public void test(GameObject anterior, Sprite[] player, Sprite[] enemies,Sprite background) {}
}
