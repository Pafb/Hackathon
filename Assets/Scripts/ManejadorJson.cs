using UnityEngine;
using SimpleJSON;

public class ManejadorJson : MonoBehaviour {
	private string j="{}";
	
	public void crearDepartamento(string nombreInterno, string nombre,string imagen){
		var N = JSONNode.Parse(j);
		N[nombreInterno]["nombre"]=nombre;
		N[nombreInterno]["imagen"]=imagen;
		j=N.ToString();
	}
	
	public void crearJuego(string departamento, string nombre, string fondo, string obstaculos, string imgPath){
		var N = JSONNode.Parse(j);
		N[departamento]["juego"]["nombre"]=nombre;
		N[departamento]["juego"]["fondo"]=fondo;
		N[departamento]["juego"]["obstaculos"]=obstaculos;
		N[departamento]["juego"]["imgPath"]=imgPath;
		j=N.ToString();
	}
	
	public void crearCategoria(string departamento, string nombreInterno, string nombre){
		var N = JSONNode.Parse(j);
		N[departamento]["categoria"][nombreInterno]=nombre;
		j=N.ToString();
	}
	
	public void crearProducto(string departamento, string categoria, string nombre,string imagen, string url){
		var N = JSONNode.Parse(j);
		N[departamento]["categoria"][categoria][nombre]["nombre"]=nombre;
		N[departamento]["categoria"][categoria][nombre]["imagen"]=imagen;
		N[departamento]["categoria"][categoria][nombre]["url"]=url;
		j=N.ToString();
	}

	public string obtenerJSON(){
		return j;
	}
	


	public void printJSON(){
		var N = JSONNode.Parse(j);
		Debug.Log(N.ToString(""));
	}
	
	
}
