<?php 


class ControladorPlantilla{


    public function ctrTraerPlantilla(){
        include "vistas/plantilla.php";
    }

    public function ctrControlarEnlaces(){

        if(isset($_GET["pagina"])){

            $controladorEnlace = $_GET["pagina"];
        }
        else{
            $controladorEnlace = "";
        }
            $respuesta = EnlacesPagina::enlacesPaginasModelo($controladorEnlace);
            include $respuesta;
		}
		
	public function ctrNombre(){
		$peticion = CurlRequest::nombreSendPost();
		$res_json = json_decode($peticion,true);
		echo '<div class="alert alert-primary" role="alert">';
		echo "Hola ".$res_json["message"]." ".$res_json["nombre"]." ".$res_json["apellido_p"]." ".$res_json["apellido_m"],", gracias por usar el servicio :)"."</div>" ;
	}


	public function ctrRut(){
		$rut = $_POST["rut"];
		$peticion = CurlRequest::rutSendPost();
		$res_json = json_decode($peticion, true);
		if($res_json["message"] == "V"){
			echo '<div class="alert alert-success" role="alert" >';
			echo "El rut ".$rut." ingresado es valido :)".'</div>';
		}else{
			echo '<div class="alert alert-danger" role="alert" >';
			echo "El rut ".$rut." ingresado es invalido :("."</div>";
		}
	}

}

 ?>