package PracticaArbolesBinarios;

public class punto8 {
	
	public boolean esPrefijo(BinaryTree<Integer> arbol1, BinaryTree<Integer> arbol2) {
		boolean ok = false;
		if((arbol1 != null && !arbol1.isEmpty()) && (arbol2 != null && !arbol2.isEmpty())) {
			ok = recorrer(arbol1,arbol2);
		}
		return ok;
	}
	
	private boolean recorrer(BinaryTree<Integer> arbol1, BinaryTree<Integer> arbol2) {
		boolean ok = true;
		if(arbol1.getData().equals(arbol2.getData())){
			if(arbol1.hasLeftChild() && arbol2.hasLeftChild()) {
				boolean izq = recorrer(arbol1.getLeftChild(),arbol2.getLeftChild());
				if(izq == false) {
					ok = false;
				}
			}else if(arbol1.hasLeftChild() && !arbol2.hasLeftChild()){
				ok = false;
			}
			if(ok && arbol1.hasRightChild() && arbol2.hasRightChild()) {
				boolean der = recorrer(arbol1.getRightChild(),arbol2.getRightChild());
				if(der == false) {
					ok = false;
				}
			}else if(arbol1.hasRightChild() && !arbol2.hasRightChild()){
				ok = false;
			}
		}else{
			ok = false;
		}
		return ok;
	}
	
}
