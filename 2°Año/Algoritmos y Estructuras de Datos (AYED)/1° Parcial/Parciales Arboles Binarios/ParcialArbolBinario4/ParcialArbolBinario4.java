package ParcialesArboles;

import java.util.List;

public class ParcialArbolBinario4 {

	public List<Integer> resolver (BinaryTree<Integer> arbol){
		List<Integer> lista = new LinkedList<Integer>();
		if(arbol != null && !arbol.isEmpty()) {
			devolverLista(arbol,lista);
		}
		return lista;
	}
	
	private int devolverLista (BinaryTree<Integer> arbol, List<Integer> lista) {
		int izq=0;
		int der=0;
		if(arbol.hasLeftChild()) {
			izq = devolverLista(arbol.getLeftChild(),lista);
		}
		if(arbol.hasRightChild()) {
			der = devolverLista(arbol.getRightChild(),lista);
		}
		if(izq == der) {
			lista.add(arbol.getData());
		}
		return 1+izq+der;
	}
	
}
