package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral7 {
	
	public List<List<Character>> caminosPares(GeneralTree<Character>arbol){
		List<List<Character>> lista = new LinkedList<List<Character>>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,lista,new LinkedList<Character>());
		}
		return lista;
	}
	
	private void recorrer(GeneralTree<Character>arbol, List<List<Character>> lista, List<Character> listaActual){
		listaActual.add(arbol.getData());
		if(arbol.isLeaf()) {
			if(listaActual.size() % 2 == 0) {
				lista.add(new LinkedList<Character>(listaActual));
			}
		}else {
			for(GeneralTree<Character> hijo : arbol.getChildren()) {
				recorrer(hijo,lista,listaActual);
			}
		}
		listaActual.remove(listaActual.size()-1);
	}
	
}
