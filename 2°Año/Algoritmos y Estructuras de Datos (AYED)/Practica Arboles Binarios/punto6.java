package PracticaArbolesBinarios;

public class punto6 {

	private BinaryTree<Integer> arbol;
	
	public BinaryTree<Integer> suma(){
		if(this.arbol != null && !this.arbol.isEmpty()) {
			recorrer(this.arbol);
		}
		return this.arbol;
	}
	
	private int recorrer(BinaryTree<Integer> arbol) {
		int izq = 0;
		int der = 0;
		if(arbol.hasLeftChild()) {
			izq = recorrer(arbol.getLeftChild());
		}
		if(arbol.hasRightChild()) {
			der = recorrer(arbol.getRightChild());
		}
		int valor = arbol.getData();
		arbol.setData(izq+der);
		return valor+izq+der;
	}
	
}
