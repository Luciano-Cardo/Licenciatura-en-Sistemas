package PracticaArbolesBinarios;

public class punto4 {

	public int retardoReenvio(BinaryTree<Integer> arbol) {
		int retardo = 0;
		if(arbol != null && !arbol.isEmpty()) {
			retardo = calcularRetardo(arbol,0,Integer.MIN_VALUE);
		}
		return retardo;
	}
	
	private int calcularRetardo(BinaryTree<Integer>arbol, int retardoActual, int retardoMaximo) {
		retardoActual += arbol.getData();
		if(arbol.isLeaf()) {
			if(retardoActual >= retardoMaximo) {
				retardoMaximo = retardoActual;
			}
		}else {
			if(arbol.hasLeftChild()) {
				retardoMaximo = calcularRetardo(arbol.getLeftChild(),retardoActual,retardoMaximo);
			}
			if(arbol.hasRightChild()) {
				retardoMaximo = calcularRetardo(arbol.getRightChild(),retardoActual,retardoMaximo);
			}
		}
		return retardoMaximo;
	}
	
}
