package PracticaArbolesGenerales;

public class punto5 {
	
	public boolean esAncestro(GeneralTree<Integer> a, GeneralTree<Integer> b) {
		boolean ok=false;
		if(a !=  null && !a.isEmpty()) {
			GeneralTree<Integer> resultado = recorrer(a,b);
			if(resultado != null) {
				ok=true;
			}
		}
		return ok;
	}
	
	private GeneralTree<Integer> recorrer(GeneralTree<Integer> a, GeneralTree<Integer> b){
		GeneralTree<Integer> resultado = null;
		if(a.getData().equals(b.getData())) {
			resultado = b;
		}else {
			List<GeneralTree<Integer>> hijos = a.getChildren();
			Iterator<GeneralTree<Integer>> iterador = hijos.iterator();
			while(resultado == null && iterador.hasNext()) {
				resultado = recorrer(iterador.next(),b);
			}
		}
		return resultado;
	}
	
}
