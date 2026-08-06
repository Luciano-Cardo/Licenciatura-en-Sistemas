package ParcialesArboles;

public class ParcialArbolBinario10 {
	
	public Integer sumarImparesPosOrdenMayorA(BinaryTree<Integer> arbol, int limite) {
		int suma = 0;
		if(arbol != null && !arbol.isEmpty()) {
			suma = recorrer(arbol,limite);
		}
		return suma;
	}
	
	private int recorrer(BinaryTree<Integer> arbol, int limite) {
		int suma = 0;
		if(arbol.hasLeftChild()) {
			suma += recorrer(arbol.getLeftChild());
		}
		if(arbol.hasRightChild()) {
			suma += recorrer(arbol.getRightChild());
		}
		if(arbol.getData() % 2 != 0){
			if(arbol.getData() > limite) {
				suma += arbol.getData();
			}
		}
		return suma;
	}
	
}
