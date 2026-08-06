package PracticaArbolesGenerales;

public class punto11 {
	
	public static boolean resolver(GeneralTree<Integer> arbol) {
		boolean esCreciente = true;
		int elementos = 0;
		int elementosAnterior = 0;
		if(arbol != null && !arbol.isEmpty()) {
			Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
			GeneralTree<Integer> ag = null;
			cola.enqueue(arbol);
			cola.enqueue(null);
			while(!cola.isEmpty() && esCreciente) {
				ag = cola.dequeue();
				if(ag != null) {
					elementos++;
					for(GeneralTree<Integer> hijo : ag.getChildren()) {
						cola.enqueue(hijo);
					}
				}else {
					if(elementos != elementosAnterior+1) {
						esCreciente = false;
					}
					if(!cola.isEmpty()) {
						elementosAnterior++;
						elementos = 0;
						cola.enqueue(null);
					}
				}
			}
		}
		return esCreciente;
	}
	
}
