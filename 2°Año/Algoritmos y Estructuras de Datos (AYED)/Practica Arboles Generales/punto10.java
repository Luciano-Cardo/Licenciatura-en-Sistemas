package PracticaArbolesGenerales;

import java.util.List;

public class punto10 {
	
	public static List<Integer> resolver(GeneralTree<Integer> arbol){
		List<Integer> lista = new LinkedList<Integer>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,lista,new LinkedList<Integer>(),0,0,Integer.MIN_VALUE);
		}
		return lista;
	}
	
	private int recorrer(GeneralTree<Integer> arbol, List<Integer> lista, List<Integer> listaActual, int nivel, int sumaActual, int sumaMaxima) {
		boolean ok = false;
		if(arbol.getData() == 1) {
			listaActual.add(arbol.getData());
			ok = true;
		}
		sumaActual += arbol.getData() * nivel;
		if(arbol.isLeaf()) {
			if(sumaActual > sumaMaxima) {
				sumaMaxima = sumaActual;
				lista.clear();
				lista.addAll(listaActual);
			}
		}else {
			for(GeneralTree<Integer> hijo : arbol.getChildren()) {
				sumaMaxima = recorrer(hijo,lista,listaActual,nivel+1,sumaActual,sumaMaxima);
			}
		}
		if(ok) {
			listaActual.remove(listaActual.size()-1);
		}
		return sumaMaxima;
	}
	
}
