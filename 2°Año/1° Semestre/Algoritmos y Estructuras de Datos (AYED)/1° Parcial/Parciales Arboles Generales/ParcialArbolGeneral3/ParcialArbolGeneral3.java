package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral3 {
	
	private GeneralTree<Integer> arbol;
	
	public parcialArbolGeneral3(GeneralTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	public List<GeneralTree<Integer>> nivel (int num){
		List<GeneralTree<Integer>> lista = new LinkedList<GeneralTree<Integer>>();
		List<GeneralTree<Integer>> listaNivelActual = new LinkedList<GeneralTree<Integer>>();
		boolean seguir = true;
		boolean nivelValido = true;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
			GeneralTree<Integer> ag = null;
			cola.enqueue(this.arbol);
			cola.enqueue(null);
			while(!cola.isEmpty() && seguir) {
				ag = cola.dequeue();
				if(ag != null ) {
					listaNivelActual.add(ag);
					if(ag.getChildren().size() < num) {
						nivelValido = false;
					}
					for(GeneralTree<Integer> hijo : ag.getChildren()) {
						cola.enqueue(hijo);
					}
				}else {
					if(nivelValido) {
						lista.addAll(listaNivelActual);
						seguir = false;
					}else{
						lista.clear();
						nivelValido = true;
						if(!cola.isEmpty()) {
							cola.enqueue(null);
						}
					}
				}
			}
		}
		return lista;
	}
	
}
