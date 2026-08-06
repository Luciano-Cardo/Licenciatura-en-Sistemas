package PracticaArbolesGenerales;

public class punto9 {
	
	public static boolean esDeSeleccion (GeneralTree<Integer> arbol) {
		boolean ok = false;
		if(arbol != null && !arbol.isEmpty()) {
			ok = recorrer(arbol);
		}
		return ok;
	}
	
	private boolean recorrer(GeneralTree<Integer> arbol) {
		boolean ok = true;
		int min = Integer.MAX_VALUE;
		for(GeneralTree<Integer> hijo : arbol.getChildren()) {
			if(hijo.getData() < min) {
				min = hijo.getData();
			}
			if(!recorrer(hijo)) {
				ok = false;
			}
		}
		if(arbol.getData() != min) {
			ok = false;
		}
		return ok;
	}
	
}
