package ParcialesArboles;

public class ParcialArbolBinario3 {

	public BinaryTree<Integer> arbol;
	
	public boolean isTwoTree (int num) {
		boolean ok = false;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			BinaryTree<Integer> subArbol = buscarSubArbol(this.arbol,num);
			if(subArbol != null) {
				ok = recorrer(subArbol);
			}
		}
		return ok;
	}
	
	private boolean recorrer (BinaryTree<Integer> arbol) {
		int izq = -1;
		int der = -1;
		if(arbol.hasLeftChild()) {
			izq = contar(arbol.getLeftChild(),0);
			
		}
		if(arbol.hasRightChild()) {
			der = contar(arbol.getRightChild(),0);
		}
		return izq==der;
	}
	
	private int contar (BinaryTree<Integer> arbol, int cantidad) {
		if(arbol.hasLeftChild() && arbol.hasRightChild()) {
			cantidad++;
		}
		if(arbol.hasLeftChild()) {
			cantidad = contar(arbol.getLeftChild(),cantidad);
		}
		if(arbol.hasRightChild()) {
			cantidad = contar(arbol.getRightChild(),cantidad);
		}
		return cantidad;
	}
	
	private BinaryTree<Integer> buscarSubArbol (BinaryTree<Integer> arbol, int num){
		BinaryTree<Integer> subArbol = null;
		if(arbol.getData() == num) {
			subArbol = arbol;
		}else {
			if(arbol.hasLeftChild()) {
				subArbol = buscarSubArbol(arbol.getLeftChild(),num);
			}
			if(subArbol == null && arbol.hasRightChild()) {
				subArbol = buscarSubArbol(arbol.getRightChild(),num);
			}
		}
		return subArbol;
	}
	
}
