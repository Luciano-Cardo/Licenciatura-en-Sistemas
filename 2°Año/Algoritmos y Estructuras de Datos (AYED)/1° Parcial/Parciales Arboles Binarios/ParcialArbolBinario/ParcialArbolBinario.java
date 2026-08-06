package ParcialesArboles;

import java.util.List;

public class ParcialArbolBinario {

	public List<Integer> resolver (BinaryTree<Integer> arbol, int min){
		List<Integer> camino = new LinkedList<Integer>();
		if(arbol != null && !arbol.isEmpty()) {
			devolverCamino(arbol,camino,min,0);
		}
		return camino;
	}
	
	private boolean devolverCamino (BinaryTree<Integer> arbol, List<Integer> camino, int min, int pares) {
		boolean encontro = false;
		camino.add(arbol.getData());
		if(arbol.getData() % 2 == 0) {
			pares++;
		}
		if(arbol.isLeaf()) {
			if(pares >= min) {
				encontro = true;
			}
		}else {
			if(arbol.hasLeftChild()) {
				encontro = devolverCamino(arbol.getLeftChild(),camino,min,pares);
			}
			if(!encontro && arbol.hasRightChild()) {
				encontro = devolverCamino(arbol.getRightChild(),camino,min,pares);
			}
		}
		if(!encontro) {
			camino.remove(camino.size()-1);
		}
		return encontro;
	}
	
}
