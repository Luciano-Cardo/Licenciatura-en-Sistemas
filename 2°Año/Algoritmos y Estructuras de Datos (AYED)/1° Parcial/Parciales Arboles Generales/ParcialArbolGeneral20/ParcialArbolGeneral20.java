package ParcialesArboles;

public class ParcialArbolGeneral20 {
		
	public int resolver(GeneralTree<Integer> arbol) {
		int producto = 1;
		if(arbol != null && !arbol.isEmpty()) {
			Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
			GeneralTree<Integer> ag = null;
			cola.enqueue(arbol);
			cola.enqueue(null);
			while(!cola.isEmpty()) {
				ag = cola.dequeue();
				if(ag != null) {
					if(ag.isLeaf()) {
						producto *= ag.getData();
					}
					for(GeneralTree<Integer> hijo : ag.getChildren()) {
						cola.enqueue(hijo);
					}
				}else {
					if(!cola.isEmpty()) {
						producto = 1;
						cola.enqueue(null);
					}
				}
			}
		}
		return producto;
	}
	
}
