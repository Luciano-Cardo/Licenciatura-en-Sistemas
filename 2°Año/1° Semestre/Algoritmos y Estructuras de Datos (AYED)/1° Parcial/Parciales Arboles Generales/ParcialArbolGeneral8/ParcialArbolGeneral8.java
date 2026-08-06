package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral8 {
	
	private GeneralTree<Integer> arbol;

	private ParcialArbolGeneral8(GeneralTree<Integer> arbol) {
		this.arbol = arbol;
	}

	public List<Integer> resolver(){
		List<Integer> lista = new LinkedList<Integer>();
		if(this.arbol != null && !this.arbol.isEmpty()) {
			recorrer(this.arbol,lista);
		}
		return lista;
	}

	private int recorrer(GeneralTree<Integer> arbol, List<Integer> lista) {
		int suma = 0;
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			suma += recorrer(hijo,lista);
		}
		if(!arbol.isLeaf()) {
			if(arbol.getChildren().getSize() % 2 != 0) {
				lista.add(suma);
			}
		}
		return arbol.getData();
	}
	
}