package ParcialesArboles;

public class ParcialArbolBinario5 {

	public BinaryTree<Integer> arbolDeNietos(BinaryTree<Integer>arbol){
		BinaryTree<Integer> nuevoArbol = null;
		if(arbol != null && !arbol.isEmpty()) {
			nuevoArbol = recorrer(arbol);
		}
		return nuevoArbol;
	}
	
	private BinaryTree<Integer> recorrer(BinaryTree<Integer> arbol){
		int izq = 0;
		int der = 0;
		if(arbol.hasLeftChild()) {
			izq = contar(arbol.getLeftChild(),0);
		}
		if(arbol.hasRightChild()) {
			der = contar(arbol.getRightChild(),0);
		}
		BinaryTree<Integer> nuevoNodo = new BinaryTree<Integer>(izq+der);
		if(arbol.hasLeftChild()) {
			nuevoNodo.addLeftChild(recorrer(arbol.getLeftChild()));
		}
		if(arbol.hasRightChild()) {
			nuevoNodo.addRightChild(recorrer(arbol.getRightChild()));
		}
		return nuevoNodo;
	}
	
	private int contar(BinaryTree<Integer>arbol, int nietos) {
		if(arbol.hasLeftChild()){
			nietos++;
		}
		if(arbol.hasRightChild()) {
			nietos++;
		}
		return nietos;
	}
	
}
