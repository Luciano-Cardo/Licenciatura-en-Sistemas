package ParcialesArboles;

public class ParcialArbolBinario1 {

	private BinaryTree<Integer> arbol;
	
	public ParcialArbolBinario1(BinaryTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public class Resultado{
		List<BinaryTree<Integer>> lista = new LinkedList<BinaryTree<Integer>>();
		int pares = 0;
	}
	
	public Resultado procesar() {
		Resultado res = new Resultado();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			recorrer(this.arbol,res);
		}
		return res;
	}
	
	private void recorrer (BinaryTree<Integer> arbol, Resultado res) {
		if(arbol.getData() % 2 == 0) {
			res.pares++;
			if(arbol.hasLeftChild() && arbol.hasRightChild()) {
				res.lista.add(arbol);
			}
		}
		if(arbol.hasLeftChild()) {
			recorrer(arbol.getLeftChild(),res);
		}
		if(arbol.hasRightChild()) {
			recorrer(arbol.getRightChild(),res);
		}
	}
}
