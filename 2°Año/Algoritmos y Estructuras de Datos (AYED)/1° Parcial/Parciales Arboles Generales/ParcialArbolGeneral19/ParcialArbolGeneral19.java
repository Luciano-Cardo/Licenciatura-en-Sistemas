package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral19 {
	
	private GeneralTree<Integer> arbol;
	
	private ParcialArbolGeneral19(GeneralTree<Integer>arbol) {
		this.arbol = arbol;
	}
	
	public List<Integer> resolver(GeneralTree<Integer> arbol){
		List<Integer> lista = new LinkedList<Integer>();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			recorrer(this.arbol,lista);
		}
		return lista;
	}
	
	private void recorrer(GeneralTree<Integer> arbol, List<Integer> lista) {
		if(arbol.isLeaf()) {
			if(arbol.getData() % 2 == 0) {
				lista.add(arbol.getData());
			}
		}else {
			for(GeneralTree<Integer> hijo : arbol.getChildren()) {
				recorrer(hijo,lista);
			}
		}
	}
	
}
