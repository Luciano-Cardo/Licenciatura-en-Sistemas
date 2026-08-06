package ParcialesArboles;

public class ParcialArbolGeneral15 {
	
	public class Resultado{
		int positivos = 0;
		int negativos = 0;
	}
	
	public int resolver(GeneralTree<Integer> arbol) {
		Resultado res = new Resultado();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,res);
		}
		if(res.positivos+res.negativos % 2 == 0) {
			return res.positivos;
		}else {
			return res.negativos;
		}
	}
	
	private void recorrer(GeneralTree<Integer> arbol, Resultado res) {
		List<GeneralTree<Integer>> hijos = arbol.getChildren();
		if(!hijos.isEmpty()) {
			recorrer(hijos.get(0),res);
		}
		if(arbol.getData() >= 0) {
			res.positivos++;
		}else {
			res.negativos++;
		}
		for(int i=1; i < hijos.size(); i++) {
			recorrer(hijos.get(i),res);
		}
	}
	
}
