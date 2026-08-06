package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral9 {

	 public List<Integer> caminoLargo(GeneralTree<Integer>arbol){
		 List<Integer> camino = new LinkedList<Integer>();
		 if(arbol != null && !arbol.isEmpty()) {
			 recorrer(arbol,camino,new LinkedList<Integer>());
		 }
		 return camino;
	 }
	 
	 private void recorrer(GeneralTree<Integer>arbol, List<Integer> caminoLargo, List<Integer> caminoActual) {
		 caminoActual.add(arbol.getData());
		 if(arbol.isLeaf()) {
			 if(caminoActual.size() > caminoLargo.size()) {
				 caminoLargo.clear();
				 caminoLargo.addAll(caminoActual);
			 }
		 }else {
			 for(GeneralTree<Integer> hijo : arbol.getChildren()) {
				 recorrer(hijo,caminoLargo,caminoActual);
			 }
		 }
		 caminoActual.remove(caminoActual.size()-1);
	 }
	
}
