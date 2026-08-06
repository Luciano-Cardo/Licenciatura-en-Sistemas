package PracticaArbolesGenerales;

import java.util.List;

public class punto7 {
	
	private GeneralTree<Integer> arbol;
	
	private punto7(GeneralTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public List<Integer> caminoAHojaMasLejana(){
		List<Integer> camino = new LinkedList<Integer>();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			recorrer(this.arbol, camino, new LinkedList<Integer>());
		}
		return camino;
	}
	
	private void recorrer(GeneralTree<Integer> arbol, List<Integer> camino, List<Integer> caminoActual) {
		caminoActual.add(arbol.getData());
		if(arbol.isLeaf()) {
			if(caminoActual.size() > camino.size()) {
				camino.clear();
				camino.addAll(caminoActual);
			}
		}else {
			for(GeneralTree<Integer> hijo : arbol.getChildren()) {
				recorrer(hijo,camino,caminoActual);
			}
		}
		caminoActual.remove(caminoActual.size()-1);
	}
	
}
