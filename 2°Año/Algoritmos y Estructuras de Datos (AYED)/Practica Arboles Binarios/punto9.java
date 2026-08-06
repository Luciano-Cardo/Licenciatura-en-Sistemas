package PracticaArbolesBinarios;

public class punto9 {
	
	public class Datos {
	    private int suma;
	    private int diferencia;

	    public Datos(int suma, int diferencia) {
	        this.suma = suma;
	        this.diferencia = diferencia;
	    }
	}
	
	public BinaryTree <Datos> sumAndDif(BinaryTree<Integer> arbol){
		BinaryTree<Datos> nuevoArbol = null;
		if(arbol != null && !arbol.isEmpty()) {
			nuevoArbol = recorrer(arbol,0,0);
		}
		return nuevoArbol;
	}
	
	private BinaryTree<Datos> recorrer(BinaryTree<Integer> arbol, int sumaTotal, int valorPadre){
		int suma = arbol.getData() + sumaTotal;
		int diferencia = arbol.getData() - valorPadre;
		Datos info = new Datos(suma,diferencia);
		BinaryTree<Datos> nuevoNodo = new BinaryTree<Datos>(info);
		if(arbol.hasLeftChild()) {
			nuevoNodo.addLeftChild(recorrer(arbol.getLeftChild(),suma,arbol.getData()));
		}
		if(arbol.hasRightChild()) {
			nuevoNodo.addRightChild(recorrer(arbol.getRightChild(),suma,arbol.getData()));
		}
		return nuevoNodo;
	}
	
}
