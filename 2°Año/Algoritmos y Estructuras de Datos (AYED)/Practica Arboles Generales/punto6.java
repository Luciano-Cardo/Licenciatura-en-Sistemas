package PracticaArbolesGenerales;

public class punto6 {
	
	private GeneralTree<Character> arbol;
	
	public punto6(GeneralTree<Character> arbol) {
		this.arbol = arbol;
	}
	
	public double minimo(double caudal) {
		double minimo = -1;
		if(this.arbol != null && !this.arbol.isEmpty()) {
			minimo = recorrer(this.arbol,caudal);
		}
		return minimo;
	}
	
	private double recorrer(GeneralTree<Character> arbol, double caudal) {
		double min;
		if(arbol.isLeaf()) {
			min = caudal;
		}else {
			caudal = caudal / arbol.getChildren().size();
			double minGlobal = Integer.MAX_VALUE;
			for(GeneralTree<Character> hijo : arbol.getChildren()) {
				double minRama = recorrer(hijo,caudal);
				if(minRama < minGlobal) {
					minGlobal = minRama;
				}
			}
			min = minGlobal;
		}
		return min;
	}
	
}
