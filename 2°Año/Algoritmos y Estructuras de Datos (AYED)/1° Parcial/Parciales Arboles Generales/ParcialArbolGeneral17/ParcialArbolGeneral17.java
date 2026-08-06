package ParcialesArboles;

public class ParcialArbolGeneral17 {

	public List<String> resolver(int menor, int mayor, GeneralTree<Integer> arbol){
		List<String> lista = new LinkedList<String>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(menor,mayor,arbol,lista,0);
		}
		return lista;
	}
	
	private void recorrer(int menor, int mayor, GeneralTree<Integer> arbol, List<String> lista, int nivel) {
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			recorrer(menor,mayor,hijo,lista,nivel + 1);
		}
		if(arbol.getData() >= menor && arbol.getData() <= mayor) {
			 lista.add("Valor: " + arbol.getData() + ", Nivel: " + nivel);
		}
	}
	
}
