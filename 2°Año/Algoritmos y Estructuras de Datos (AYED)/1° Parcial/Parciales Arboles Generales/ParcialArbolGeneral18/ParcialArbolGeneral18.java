package ParcialesArboles;

public class ParcialArbolGeneral18 {
	
	public List<String> resolver(int menor, int mayor, GeneralTree<Integer> arbol){
		List<String> lista = new LinkedList<String>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(menor,mayor,arbol,lista,0);
		}
		return lista;
	}
	
	private void recorrer(int menor, int mayor, GeneralTree<Integer> arbol, List<String> lista, int nivel) {
		List<GeneralTree<Integer>> hijos = arbol.getChildren();
		if(!hijos.isEmpty()) {
			recorrer(menor,mayor,hijos.get(0),lista,nivel+1);
		}
		if(arbol.getData() >= menor && arbol.getData() <= mayor) {
			 lista.add("Valor: " + arbol.getData() + ", Nivel: " + nivel);
		}
		for(int i=1; i < hijos.size(); i++) {
			recorrer(menor,mayor,hijos.get(i),lista,nivel + 1);
		}
	}
	
}
