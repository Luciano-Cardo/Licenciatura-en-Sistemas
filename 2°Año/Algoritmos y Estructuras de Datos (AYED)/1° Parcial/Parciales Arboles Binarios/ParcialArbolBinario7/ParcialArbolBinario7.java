package ParcialesArboles;

public class ParcialArbolBinario7 {

	private BinaryTree<Integer> arbol;
	
	public ParcialArbolBinario7(BinaryTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public BinaryTree<Integer> minEnNiveldeAB (int n){
		int nivel = 0;
		int minValor = Integer.MAX_VALUE;
		BinaryTree<Integer> subArbol = null;
		boolean encontrado = false;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			Queue<BinaryTree<Integer>> cola = new Queue<BinaryTree<Integer>>();
			BinaryTree<Integer> ab = null;
			cola.enqueue(this.arbol);
			cola.enqueue(null);
			while(!cola.isEmpty() && !encontrado) {
				ab = cola.dequeue();
				if(ab != null) {
					if(nivel == n) {
						if(ab.isLeaf()) {
							if(ab.getData() < minValor) {
								minValor = ab.getData();
								subArbol = ab;
								encontrado = true;
							}
						}
					}
					if(!encontrado) {
						if(ab.hasLeftChild()) {
							cola.enqueue(ab.getLeftChild());
						}
						if(ab.hasRightChild()) {
							cola.enqueue(ab.getRightChild());
						}
					}
				}
				else {
					if(!cola.isEmpty()) {
						nivel++;
						if(nivel > n) {
							encontrado = true;
						}else {
							cola.enqueue(null);
						}
				}
			}
		}
		return subArbol;
	}
}
