package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral1 {
	
	public static List<Integer> primerCaminoAlternanteCeroNoCero (GeneralTree<Integer> arbol){
		List<Integer> camino = new LinkedList<Integer>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,camino,arbol.getData() % 10 == 0);
		}
		return camino;
	}
	
	private boolean recorrer(GeneralTree<Integer> arbol, List<Integer> camino, boolean esCero) {
		camino.add(arbol.getData());
		boolean encontre = false;
		if(arbol.isLeaf()) {
			encontre=true;
		}else {
			List<GeneralTree<Integer>> hijos = arbol.getChildre();
			Iterator<GeneralTree<Integer>> iterador = hijos.iterator();
			while(!encontre && iterador.hasNext()) {
				GeneralTree<Integer> hijo = iterador.next();
				boolean cumple = (esCero && hijo.getData() % 10 != 0 || !esCero && hijo.getData() % 10 == 0);
				if(cumple) {
					encontre = recorrer(hijo,camino,!esCero);
				}
			}
		}
		if(!encontre) {
			camino.remove(camino.size()-1);
		}
		return encontre;	
	}
	
}
