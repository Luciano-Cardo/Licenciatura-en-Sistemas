package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral21 {
	
	public List<String> devolverCamino(GeneralTree<String> arbol){
		List<String> lista = new LinkedList<String>();
		if(arbol != null && !arbol.isEmpty() && !arbol.getData().equals("Dragon")) {
			recorrer(arbol,lista);
		}
		return lista;
	}
	
	private boolean recorrer(GeneralTree<String> arbol, List<String> lista) {
		boolean encontre = false;
		lista.add(arbol.getData());
		if(arbol.getData().equals("Princesa")) {
			encontre = true;
		}else {
			List<GeneralTree<String>> hijos = arbol.getChildren();
			Iterator<GeneralTree<String>> iterador = hijos.iterator();
			while (!encontre && iterador.hasNext()) {
				GeneralTree<String> hijo = iterador.next();
				if(!hijo.getData().equals("Dragon")) {
					encontre = recorrer(hijo,lista);
				}
			}
		}
		if(!encontre) {
			lista.remove(lista.size()-1);
		}
		return encontre;
	}
	
}
