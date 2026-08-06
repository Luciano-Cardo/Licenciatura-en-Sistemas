package ParcialesArboles;

public class ParcialArbolBinario9 {

	public BinaryTree<Integer> sumarArboles (BinaryTree<Integer> arbol1, BinaryTree<Integer> arbol2){
		BinaryTree<Integer> nuevoArbol = new BinaryTree<Integer>();
		if((arbol1 != null && !arbol1.isEmpty()) && (arbol2 != null && !arbol2.isEmpty())) {
			BinaryTree<Integer> resultado = recorrer(arbol1,arbol2);
			if(resultado != null) {
				nuevoArbol = resultado;
			}
		}
		return nuevoArbol;
	}
	
	private BinaryTree<Integer> recorrer(BinaryTree<Integer> arbol1, BinaryTree<Integer> arbol2){
		boolean ok = true;
		BinaryTree<Integer> nuevoNodo = new BinaryTree<Integer>(arbol1.getData()+arbol2.getData());
		if(arbol1.hasLeftChild() && arbol2.hasLeftChild()) {
			BinaryTree<Integer> izq = recorrer(arbol1.getLeftChild(),arbol2.getLeftChild());
			if(izq != null) {
				nuevoNodo.addLeftChild(izq);
			}else {
				ok = false;
			}
		}else if(arbol1.hasLeftChild() || arbol2.hasLeftChild()) {
			ok = false;
		}
		if(ok && arbol1.hasRightChild() && arbol2.hasRightChild()) {
			BinaryTree<Integer> der = recorrer(arbol1.getRightChild(),arbol2.getRightChild());
			if(der != null) {
				nuevoNodo.addRightChild(der);
			}else {
				ok = false;
			}
		}else if(arbol1.hasRightChild() || arbol2.hasRightChild()) {
			ok = false;
		}
		BinaryTree<Integer> resultado = null;
		if(ok) {
			resultado = nuevoNodo;
		}
		return resultado;	
	}
	
}

