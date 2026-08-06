package ParcialesArboles;

public class ParcialArbolGeneral23 {
	
	public List<GeneralTree<Integer>> resolver(GeneralTree<Integer> arbol){
		List<GeneralTree<Integer>> lista = new LinkedList<GeneralTree<Integer>>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,lista);
		}
		return lista;
	}
	
	private int recorrer(GeneralTree<Integer> arbol, List<GeneralTree<Integer>> lista) {
		int suma = 0;
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			suma += recorrer(hijo,lista);
		}
		int valorRaiz = arbol.getData();
		if(valorRaiz < suma) {
			lista.add(arbol);
		}
		return valorRaiz;
	}
	
}