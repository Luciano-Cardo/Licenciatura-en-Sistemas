package ParcialesArboles;

public class ParcialArbolGeneral11 {
	
	public List<Compuesto> mejorEstrategia(GeneralTree<Compuesto> arbol){
		List<Compuesto> lista = new LinkedList<Compuesto>();
		if(arbol != null && !arbol.isEmpty()) {
			recorrer(arbol,lista,new LinkedList<Compuesto>(),0,Double.MAX_VALUE);
		}
		return lista;
	}
	
	private double recorrer(GeneralTree<Compuesto> arbol, List<Compuesto> lista, List<Compuesto> listaActual, double sumaActual, double minSuma) {
		if(arbol.getData().getCompuesto().equals("Soft")) {
			sumaActual += arbol.getData().getVueltas() * 0;
		}else if(arbol.getData().getCompuesto().equals("Med")) {
			sumaActual += arbol.getData().getVueltas() * 0.4;
		}else if(arbol.getData().getCompuesto().equals("Hard")){
			sumaActual += arbol.getData().getVueltas() * 0.7;
		}
		listaActual.add(arbol.getData());
		if(arbol.isLeaf()) {
			if(sumaActual < minSuma) {
				minSuma = sumaActual;
				lista.clear();
				lista.addAll(listaActual);
			}
		}else {
			for(GeneralTree<Compuesto> hijo : arbol.getChildren()) {
				minSuma = recorrer(hijo,lista,listaActual,sumaActual+10,minSuma);
			}
		}
		listaActual.remove(listaActual.size()-1);
		return minSuma;
	}
	
}
