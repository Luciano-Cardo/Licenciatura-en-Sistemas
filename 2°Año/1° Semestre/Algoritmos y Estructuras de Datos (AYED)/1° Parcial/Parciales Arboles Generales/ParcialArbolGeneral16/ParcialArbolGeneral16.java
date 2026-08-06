package ParcialesArboles;

public class ParcialArbolGeneral16 {
	
	public class Resultado{
		int suma = 0;
		int elementos = 0;
	}
	
	public int resolver(GeneralTree<Integer> arbol, int min, int max) {
		Resultado res = new Resultado();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,min,max,res);
		}
		return res.suma/res.elementos;
	}
	
	private void recorrer(GeneralTree<Integer> arbol, int min, int max, Resultado res) {
		List<GeneralTree<Integer>> hijos = 	arbol.getChildren();
		if(!hijos.isEmpty()) {
			recorrer(hijos.get(0),min,max,res);
		}
		if(arbol.getData() >= min && arbol.getData() <= max) {
			res.elementos++;
			res.suma += arbol.getData();
		}
		for(int i=1; i < hijos.size(); i++) {
			recorrer(hijos.get(i),min,max,res);
		}	
	}
	
}
