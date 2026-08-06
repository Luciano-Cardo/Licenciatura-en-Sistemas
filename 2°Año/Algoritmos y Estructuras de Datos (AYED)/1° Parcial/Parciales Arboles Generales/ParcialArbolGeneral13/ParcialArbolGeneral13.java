package ParcialesArboles;

public class ParcialArbolGeneral13 {
	
	public List<GeneralTree<Integer>> resolver(GeneralTree<Integer> arbol){
		List<GeneralTree<Integer>> lista = new LinkedList<GeneralTree<Integer>>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,lista);
		}
		return lista;
	}
	
	private void recorrer(GeneralTree<Integer> arbol, List<GeneralTree<Integer>> lista) {
		List<GeneralTree<Integer>> hijos = arbol.getChildren();
		if(!hijos.isEmpty()) {
			recorrer(hijos.get(0),lista);
		}
		if(!arbol.isLeaf()) {
			if(hijos.size() % 2 == 0) {
				lista.add(arbol);
			}
		}
		for(int i = 1; i < hijos.size(); i++){
			recorrer(hijos.get(i),lista);
		}
	}
	
}
