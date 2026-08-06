package ParcialesArboles;

public class ParcialArbolGeneral14 {
	
	public class Resultado {
		int positivos = 0;
		int negativos = 0;
	}
	
	public int resolver(GeneralTree<Integer> arbol) {
		Resultado res = new Resultado();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,res);
		}
		int suma = res.positivos+res.negativos;
		if(suma % 2 == 0) {
			return res.positivos;
		}else {
			return res.negativos;
		}
	}
	
	private void recorrer(GeneralTree<Integer> arbol, Resultado res) {
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			recorrer(hijo,res);
		}
		if(arbol.getData() >= 0) {
			res.positivos += arbol.getData();
		}else {
			res.negativos += arbol.getData();
		}
	}
	
}
