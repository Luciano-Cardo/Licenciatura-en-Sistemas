package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral {
	
	public static List<Integer> caminoParidadAlternante(GeneralTree<Integer> arbol){
		List<Integer> caminoLargo = new LinkedList<Integer>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,caminoLargo,new LinkedList<Integer>(),arbol.getData() % 2 == 0);
		}
		return caminoLargo;
	}
	
	private void recorrer(GeneralTree<Integer> arbol, List<Integer> caminoLargo, List<Integer> caminoActual, boolean esPar){
		caminoActual.add(arbol.getData());
		if(arbol.isLeaf()) {
			if(caminoActual.size() > caminoLargo.size()) {
				caminoLargo.clear();
				caminoLargo.addAll(caminoActual);
			}
		}else {
			for(GeneralTree<Integer> hijo : arbol.getChildren()) {
				boolean cumple = (esPar && hijo.getData() % 2 != 0 || !esPar && hijo.getData() % 2 == 0);
				if(cumple) {
					recorrer(hijo,caminoLargo,caminoActual,!esPar);
				}
			}
		}
		caminoActual.remove(caminoActual.size()-1);
	}
	
}
