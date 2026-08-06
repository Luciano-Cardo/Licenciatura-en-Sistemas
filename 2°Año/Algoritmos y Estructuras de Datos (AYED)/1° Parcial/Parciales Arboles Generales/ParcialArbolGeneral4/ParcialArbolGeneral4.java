package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral4 {
	
	private GeneralTree<Integer> arbol;
	
	private ParcialArbolGeneral4(GeneralTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public List<Integer> camino (int num){
		List<Integer> camino = new LinkedList<Integer>();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			recorrer(this.arbol,camino,num);
		}
		return camino;
	}
	
	private boolean recorrer(GeneralTree<Integer> arbol, List<Integer> camino, int num) {
		boolean encontre = false;
		camino.add(arbol.getData());
		if(arbol.isLeaf()) {
			encontre = true;
		}else {
			List<GeneralTree<Integer>> hijos = arbol.getChildren();
			if(hijos.size() >= num) {
				Iterator<GeneralTree<Integer>> iterador = hijos.iterator();
				while(!encontre && iterador.hasNext()) {
					GeneralTree<Integer> hijo = iterador.next();
					encontre = recorrer(hijo,camino,num);
				}
			}
		}
		if(!encontre) {
			camino.remove(camino.size()-1);
		}
		return encontre;
	}
	
}
