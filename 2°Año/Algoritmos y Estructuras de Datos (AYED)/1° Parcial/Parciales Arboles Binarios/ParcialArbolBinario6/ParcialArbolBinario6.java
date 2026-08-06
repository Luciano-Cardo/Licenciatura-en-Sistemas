package ParcialesArboles;

public class ParcialArbolBinario6 {
	
	private BinaryTree<Integer> arbol;
	
	public boolean resolver (int k) {
		boolean ok = false;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			ok = recorrer(this.arbol,k,0);
		}
		return ok;
	}
	
	private boolean recorrer(BinaryTree<Integer> arbol, int k, int suma) {
		boolean ok = true;
		suma += arbol.getData();
		if(arbol.isLeaf()) {
			if(suma != k) {
				ok = false;
			}
		}else {
			if(arbol.hasLeftChild()) {
				ok = recorrer(arbol.getLeftChild(),k,suma);
			}
			if(ok && arbol.hasRightChild()) {
				ok = recorrer(arbol.getRightChild(),k,suma);
			}
		}
		return ok;
	}
	
}
