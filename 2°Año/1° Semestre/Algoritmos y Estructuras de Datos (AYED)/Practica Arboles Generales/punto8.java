package PracticaArbolesGenerales;

public class punto8 {
	
	private GeneralTree<Integer> arbol;
	
	public punto8(GeneralTree<Integer> arbol) {
		this.arbol = arbol;
	}
	
	 public boolean esAbetoNavidenio() {
		 boolean ok = false;
		 if(this.arbol != null && !this.arbol.isEmpty()) {
			 ok = recorrer(this.arbol);
		 }
		 return ok;
	 }
	 
	 private boolean checkAbeto(GeneralTree<Integer> nodo) {
	        boolean result = true;
	        if (!nodo.isLeaf()) {
	            int hijosHojas = 0;
	            List<GeneralTree<Integer>> hijos = nodo.getChildren();
	            for (GeneralTree<Integer> hijo : hijos) {
	                if (hijo.isLeaf()) {
	                    hijosHojas++;
	                }
	            }
	            if (hijosHojas < 3) {
	                result = false;
	            } else {
	                Iterator<GeneralTree<Integer>> it = hijos.iterator();
	                while (it.hasNext() && result) {
	                    GeneralTree<Integer> h = it.next();
	                    if (!h.isLeaf()) {
	                        result = checkAbeto(h);
	                    }
	                }
	            }
	        }
	        return result;
	    }
	
}
