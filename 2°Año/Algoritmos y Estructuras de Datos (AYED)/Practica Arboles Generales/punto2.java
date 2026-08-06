package PracticaArbolesGenerales;

import java.util.List;

public class punto2 {
	
	public List<Integer> numerosImparesMayoresQuePreOrden (GeneralTree <Integer> a, Integer n){
		List<Integer> lista = new LinkedList<Integer>();
		if(a != null && !a.isEmpty()) {
			recorrerPreOrden(a,n,lista);
		}
		return lista;
	}
	private void recorrerPreOrden(GeneralTree<Integer> arbol, Integer n, List<Integer> lista) {
		if(arbol.getData() % 2 != 0 && arbol.getData() > n) {
			lista.add(arbol.getData());
		}
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			recorrerPreOrden(hijo,n,lista);
		}
	}
	
	public List<Integer> numerosImparesMayoresQueInOrden (GeneralTree <Integer> a, Integer n){
		List<Integer> lista = new LinkedList<Integer>();
		if(a != null && !a.isEmpty()) {
			recorrerInOrden(a,n,lista);
		}
		return lista;
	}
	private void recorrerInOrden(GeneralTree<Integer> arbol, Integer n, List<Integer> lista) {
		List<GeneralTree<Integer>> hijos = arbol.getChildren();
		if(!hijos.isEmpty()) {
			recorrerInOrden(hijos.get(0),n,lista);
		}
		if(arbol.getData() % 2 != 0 && arbol.getData() > n) {
			lista.add(arbol.getData());
		}
		for(int i=1; i < hijos.size(); i++) {
			recorrerInOrden(hijos.get(i),n,lista);
		}
	}
	
	public List<Integer> numerosImparesMayoresQuePostOrden (GeneralTree <Integer> a, Integer n){
		List<Integer> lista = new LinkedList<Integer>();
		if(a != null && !a.isEmpty()) {
			recorrerPostOrden(a,n,lista);
		}
		return lista;
	}
	private void recorrerPostOrden(GeneralTree<Integer> arbol, Integer n, List<Integer> lista) {
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			recorrerPostOrden(hijo,n,lista);
		}
		if(arbol.getData() % 2 != 0 && arbol.getData() > n) {
			lista.add(arbol.getData());
		}
	}
	
	public List<Integer> numerosImparesMayoresQuePorNiveles(GeneralTree <Integer> a, Integer n){
		List<Integer> lista = new LinkedList<Integer>();
		if(a != null && !a.isEmpty()) {
			Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
			GeneralTree<Integer> ag = null;
			cola.enqueue(a);
			while(!cola.isEmpty()) {
				ag = cola.dequeue();
				if(ag.getData() % 2 != 0 && ag.getData() > n) {
					lista.add(ag.getData());
				}
				for(GeneralTree<Integer> hijo : ag.getChildren()) {
					cola.enqueue(hijo);
				}
			}
		}
		return lista;
	}
	
}
