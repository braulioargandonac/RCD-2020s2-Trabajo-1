package sssoap;

public class servi {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String nombres = "rodRigo ignacio";
		String apellidop ="aguirre";
		String apellidom="rodriguez";
		String sexo="m";
		System.out.println(validarut ("20120947-1"));
		System.out.println(convertirAmayuscula(nombres,apellidop,apellidom,sexo));
	}
	
	public static String validarut (String x) {
        if(x.length() == 0) {
            return "Ingrese su Rut";
        }
        int rutlength = x.length();
        for(int i = 0; i<rutlength; ++i) {
            int aux = 0;
            char character = x.charAt(i);
            int ascii = (int) character;
            if (rutlength!=10) {
                return "El rut ingresado no es valido";
            }

            else if(i<8 || i == 9) {
                for (int a=48; a<=57; ++a) {
                    if(ascii == a) {
                        ++aux;}

                    else if (aux == 0 && a == 57 && ascii == 107 && i != 9) {
                        return "El rut ingresado no es valido";}
                    else if (aux == 0 && a == 57 && ascii == 107 && i == 9) {
                        ++aux;}
            }
                if(aux == 0) {
                    return "El rut ingresado no es valido";
                }
                }

            else if (i == 8 && ascii != 45) {

                return "El rut ingresado no es valido";
            }
        }
        return validadigito(x);
    }
	
	public static String validadigito (String x) {
        char[] invertido = new char[8];
        int aux = 2;
        int suma = 0;
        int a = 7;
        for (int i=0; i<8 ; ++i) {
            char normal = x.charAt(i);
            invertido[a] = normal;
            a -= 1;
        }

        for (int b=0; b<invertido.length; b++ ) {
            suma += Character.getNumericValue(invertido[b]) * aux;

            if(aux == 7) {
                aux = 1;
            }
            aux ++;
        }
        int resto = suma % 11;
        int digito = 11 - resto;
        if (digito != Character.getNumericValue(x.charAt(9)) && digito !=10 && digito !=11) {
            return "Digito Verificador ingresado no valido";
        }

        if(digito == 11 && (int)x.charAt(9) != 48 ) {
            return "Digito Verificador ingresado no valido";
        }

        if(digito == 10 && (int)x.charAt(9) != 107) {
            return "Digito Verificador ingresado no valido";
        }

        return "Rut valido";
    }
	
public static String convertirAmayuscula (String Nombres, String ApellidoPaterno, String ApellidoMaterno, String Sexo) {
		
		String stg="";
		char letrauno=' ';
		char c=' ';
		int aux=0;
		
		for(int i=0;i<Sexo.length();i++) {
			letrauno=Sexo.charAt(0);
			
			if(Sexo.length()>1) {
				stg="Sexo invalido";
				return stg;
			}
			if(letrauno=='M' || letrauno=='m') {
				stg+="Sr. ";
			}
			else if(letrauno=='F' || letrauno=='f') {
				stg+="Sra. ";
			}
			else {
				stg="Sexo invalido";
				return stg;
			}
		}
		
		for(int i=0;i<Nombres.length();i++) {
			letrauno=Nombres.charAt(0);
			c=Nombres.charAt(i);
			
			for(int j=0;j<Nombres.length();j++) {
			if(Nombres.charAt(j)== ' '){
				j++;
				
			}else if(!Character.isLetter(Nombres.charAt(j))) {
					stg="El nombre no puede contener caracteres que no sean letras";
					return stg;
				}
			}
			
			if(letrauno==' ') {
				stg="Un nombre no puede empezar por espacio";
				return stg;
			}
			
			if(i==0) {
				c=Character.toUpperCase(c);
			}
			
			if(i>=1) {
				c=Character.toLowerCase(c);
			}
			
			if(c==' ') {
				aux=(i+1);
			}
			if(aux==i) {
				c=Character.toUpperCase(c);
			}
			stg+=c;
		}
		stg+=" ";
		for(int i=0;i<ApellidoPaterno.length();i++) {
			c=ApellidoPaterno.charAt(i);
			
			for(int j=0;j<ApellidoPaterno.length();j++) {
				if(!Character.isLetter(ApellidoPaterno.charAt(j))) {
					stg="El apellido no puede contener caracteres que no sean letras";
					return stg;
				}
			}
			if(i==0) {
				c=Character.toUpperCase(c);
			}
			
			if(i>=1) {
				c=Character.toLowerCase(c);
			}
			stg+=c;
		}
		stg+=" ";
		for(int i=0;i<ApellidoMaterno.length();i++) {
			c=ApellidoMaterno.charAt(i);
			
			for(int j=0;j<ApellidoMaterno.length();j++) {
				if(!Character.isLetter(ApellidoMaterno.charAt(j))) {
					stg="El apellido no puede contener caracteres que no sean letras";
					return stg;
				}
			}
			if(i==0) {
				c=Character.toUpperCase(c);
			}
			
			if(i>=1) {
				c=Character.toLowerCase(c);
			}
			stg+=c;
		}
		
		return stg;
	}
}


