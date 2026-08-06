package PracticaArbolesBinarios;

import java.util.List;

public class punto3 {

	private BinaryTree<Integer> arbol;
	
	public punto3(BinaryTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public List<Integer> numerosPares(){
		List<Integer> listaInOrden = new LinkedList<Integer>();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			devolverListaInOrden(this.arbol,listaInOrden);
		}
		return listaInOrden;
	}
	
	private void devolverListaInOrden(BinaryTree<Integer> arbol, List<Integer> listaInOrden) {
		if(arbol.hasLeftChild()) {
			devolverListaInOrden(arbol.getLeftChild(),listaInOrden);
		}
		if(arbol.getData() % 2 == 0) {
			listaInOrden.add(arbol.getData());
		}
		if(arbol.hasRightChild()) {
			devolverListaInOrden(arbol.getRightChild(),listaInOrden);
		}
	}
	
	public List<Integer> numerosPares(){
		List<Integer> listaPostOrden = new LinkedList<Integer>();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			devolverListaPostOrden(this.arbol,listaPostOrden);
		}
		return listaPostOrden;
	}
	
	private void devolverListaPostOrden(BinaryTree<Integer> arbol, List<Integer> listaPostOrden) {
		if(arbol.hasLeftChild()) {
			devolverListaPostOrden(arbol.getLeftChild(),listaPostOrden);
		}
		if(arbol.getData() % 2 == 0) {
			listaPostOrden.add(arbol.getData());
		}
		if(arbol.hasRightChild()) {
			devolverListaPostOrden(arbol.getRightChild(),listaPostOrden);
		}
	}
	
}
