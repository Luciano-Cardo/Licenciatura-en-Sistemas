package ParcialesArboles;

public class ParcialArbolBinario2 {
	
	private BinaryTree<Integer> arbol;
	
	public ParcialArbolBinario2(BinaryTree<Integer>arbol) {
		this.arbol = arbol;
	}
	
	public BinaryTree<Integer> nuevoTree(){
		BinaryTree<Integer> nuevoArbol = null;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			nuevoArbol = recorrer(this.arbol,0,false);
		}
		return nuevoArbol;
	}
	
	private BinaryTree<Integer> recorrer(BinaryTree<Integer>arbol,int valor,boolean ok){
		if(ok) {
			valor += arbol.getData();
		}else {
			valor = arbol.getData();
		}
		BinaryTree<Integer> nuevoNodo = new BinaryTree<Integer>(valor);
		if(arbol.hasLeftChild()) {
			nuevoNodo.addLeftChild(recorrer(arbol.getLeftChild(),arbol.getData(),true));
		}
		if(arbol.hasRightChild()) {
			nuevoNodo.addRightChild(recorrer(arbol.getRightChild(),0,false));
		}
		return nuevoNodo;
	}
	
}







