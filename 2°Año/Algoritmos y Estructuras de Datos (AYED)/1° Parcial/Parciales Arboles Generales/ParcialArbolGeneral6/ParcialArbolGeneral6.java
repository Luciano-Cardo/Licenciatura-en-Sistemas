package ParcialesArboles;

public class ParcialArbolGeneral6 {
	
	public GeneralTree<Integer> resolver(GeneralTree<Integer> arbol){
		boolean esCreciente = true;
		int nivel = 0;
		int nivelAnterior = 0;
		int maxHijos = Integer.MIN_VALUE;
		GeneralTree<Integer> nodo = null;
		if(arbol != null && !arbol.isEmpty()) {
			Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
			GeneralTree<Integer> ag = null;
			cola.enqueue(arbol);
			cola.enqueue(null);
			while(!cola.isEmpty() && esCreciente) {
				ag = cola.dequeue();
				if(ag != null) {
					nivel++;
					if(ag.getChildren().size() > maxHijos) {
						maxHijos = ag.getChildren().size();
						nodo = ag;
					}
					for(GeneralTree<Integer> hijo : ag.getChildren()) {
						cola.enqueue(hijo);
					}
				}else {
					if(nivel != nivelAnterior+1) {
						esCreciente = false;
					}
					if(!cola.isEmpty()) {
						nivelAnterior++;
						nivel = 0;
						cola.enqueue(null);
					}
				}
			}
		}
		if(esCreciente) {
			return nodo;
		}else {
			return null;
		}
	}
	
}
