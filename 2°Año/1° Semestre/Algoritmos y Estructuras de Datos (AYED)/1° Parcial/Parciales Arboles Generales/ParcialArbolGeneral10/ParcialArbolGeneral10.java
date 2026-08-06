package ParcialesArboles;

public class ParcialArbolGeneral10 {
	
	public int mayorNumero(GeneralTree<Integer>arbol) {
		int valor = Integer.MIN_VALUE;
		if(arbol != null && !arbol.isEmpty()) {
			valor = recorrer(arbol,valor);
		}
		return valor;
	}
	
	private int recorrer(GeneralTree<Integer> arbol, int valor) {
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			valor = recorrer(hijo,valor);
		}
		if(valor < arbol.getData()) {
			valor = arbol.getData();
		}
		return valor;
	}
	
}
