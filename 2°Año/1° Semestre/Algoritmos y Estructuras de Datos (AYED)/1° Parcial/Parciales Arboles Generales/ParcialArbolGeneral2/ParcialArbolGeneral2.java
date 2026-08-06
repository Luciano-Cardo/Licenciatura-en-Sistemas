package ParcialesArboles;

public class ParcialArbolGeneral2 {
	
	private GeneralTree<Panel> arbol;
	
	private ParcialArbolGeneral2(GeneralTree<Panel>arbol) {
		this.arbol = arbol;
	}
	
	public double minimoSuministroEnergia(double energiaTotal, String panelInicial) {
		double minimo = -1;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			GeneralTree<Panel> subArbol = buscar(this.arbol,panelInicial);
			if(subArbol != null && subArbol.getData().isActive()) {
				minimo = recorrer(subArbol,energiaTotal);
			}
		}
		return minimo;
	}
	
	private GeneralTree<Panel> buscar(GeneralTree<Panel> arbol, String panelInicial){
		GeneralTree<Panel> subArbol = null;
		if(arbol.getData().getId().equals(panelInicial)) {
			subArbol = arbol;
		}else {
			List<GeneralTree<Panel>> hijos = arbol.getChildren();
			Iterator<GeneralTree<Panel>> iterador = hijos.iterator();
			while(subArbol == null && iterador.hasNext()) {
				GeneralTree<Panel> hijo = iterador.next();
				subArbol = buscar(hijo,panelInicial);
			}
		}
		return subArbol;
	}
	
	private double recorrer(GeneralTree<Panel> arbol, double energiaTotal) {
		double min;
		if(arbol.isLeaf()) {
			min = energiaTotal;
		}else {
			double hijosActivos = 0;
			for(GeneralTree<Panel> h : arbol.getChildren()) {
				if(h.getData().isActive()) {
					hijosActivos++;
				}
			}
			if(hijosActivos == 0) {
				min = -1;
			}else {
				energiaTotal = energiaTotal / hijosActivos;
				double minGlobal = Double.MAX_VALUE;
				boolean ok = false;
				for(GeneralTree<Panel> hijo : arbol.getChildren()) {
					if(hijo.getData().isActive()) {
						double minRama = recorrer(hijo,energiaTotal);
						if(minRama != -1) {
							if(minRama < minGlobal) {
								minGlobal = minRama;
							}
							ok = true;
						}
					}
				}
				if(ok) {
					min = minGlobal;
				}else {
					min = -1;
				}			
			}
		}
		return min;
	}
	
}
