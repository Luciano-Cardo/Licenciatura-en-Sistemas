package ParcialesArboles;

import java.util.List;

public class ParcialArbolBinario8 {
	
	//Devuelve el camino a una princesa
	public List<String> princesaAccesible (BinaryTree<String> arbol){
		List<String> camino = new LinkedList<String>();
		if(arbol != null && !arbol.isEmpty() && !arbol.esDragon()) {
			recorrer(arbol,camino);
		}
		return camino;
	}
	
	private boolean recorrer (BinaryTree<String> arbol, List<String> camino) {
		camino.add(arbol.getData());
		boolean encontro = false;
		if(arbol.esPrincesa()) {
			encontro = true;
		}else {
			if(arbol.hasLeftChild()) {
				if(!arbol.getLeftChild().esDragon()) {
					encontro = recorrer(arbol.getLeftChild(),camino);
				}
			}
			if(!encontro && arbol.hasRightChild()) {
				if(!arbol.getRightChild().esDragon()) {
					encontro = recorrer(arbol.getRightChild(),camino);
				}
			}
		}
		if(!encontro) {
			camino.remove(camino.size()-1);
		}
		return encontro;
	}
	
	
	
	
	//Devuelve un nodo princesa
	public Personaje princesaAccesible (BinaryTree<String> arbol){
		Personaje princesa = null;
		if(arbol != null && !arbol.isEmpty() && !arbol.esDragon()) {
			princesa = recorrer(arbol);
		}
		return princesa;
	}

	private Personaje recorrer (BinaryTree<String> arbol) {
		Personaje princesa = null;
		if(arbol.esPrincesa()) {
			princesa = arbol.getData();
		}else {
			if(arbol.hasLeftChild()) {
				if(!arbol.getLeftChild().esDragon()) {
					princesa = recorrer(arbol.getLeftChild());
				}
			}
			if(princesa == null && arbol.hasRightChild()) {
				if(!arbol.getRightChild().esDragon()) {
					princesa = recorrer(arbol.getRightChild());
				}
			}
		}
		return princesa;
	}
}






