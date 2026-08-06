package PracticaArbolesBinarios;

public class punto5 {

	private BinaryTree<Integer> arbol;
	
	public  punto5(BinaryTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public int sumaElementosProfundidad(int p) {
		int nivel = 0;
		int suma  = 0;
		boolean encontro = false;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			Queue<BinaryTree<Integer>> cola = new Queue<BinaryTree<Integer>>();
			BinaryTree<Integer> ab = null;
			cola.enqueue(this.arbol);
			cola.enqueue(null);
			while(!cola.isEmpty() && !encontro) {
				ab = cola.dequeue();
				if(ab != null) {
					if(nivel == p) {
						suma += ab.getData();
					}
					if(ab.hasLeftChild()) {
						cola.enqueue(ab.getLeftChild());
					}
					if(ab.hasRightChild()) {
						cola.enqueue(ab.getRightChild());
					}
				}else {
					if(!cola.isEmpty()) {
						nivel++;
						if(nivel > p) {
							encontro = true;
						}else {
							cola.enqueue(null);
						}
					}
				}
			}
		}
		return suma;
	}
	
}
