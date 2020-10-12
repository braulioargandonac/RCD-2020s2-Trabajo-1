<br>
<div class="container px-5 py-3 mt-5">
	<?php 
		if($_POST){
			$respuesta = new ControladorPlantilla();
			$respuesta -> ctrNombre();
		}
	 ?>			
</div>
<form method='post'>
	<div class="container mx-auto">
		<div class="form-group px-5 cardinicio shadow p-3 mb-5 rounded">
			<h1 class="text-center">Nombre propio</h1>
			<h4>Ingrese los siguientes datos:</h4>
			<label for="nombre">Nombres:</label><br>
			<input type="text" name="nombre" placeholder="Nombres" required="required" class="form-control">
			<br>

			<label for="apellido_p">Apellido paterno:</label><br>
			<input type="text" name="apellido_p" placeholder="Apellido paterno" required="required" class="form-control">
			<br>

			<label for="apellido_m">Apellido materno:</label><br>
			<input type="text" name="apellido_m" placeholder="Apellido materno" required="required" class="form-control">
			<br>

			<label for="sexo">Indique su género, femenino (F) o masculino (M): </label><br>
			<div class="form-check form-check-inline" >

				<input type="radio" class="form-check-input" name="sexo" id="radio1" value="F" required="required">
				<label for="radio1">F </label>		
			</div>	
			<div class="form-check form-check-inline" class="required">
				<input type="radio" class="form-check-input" name="sexo" id="radio2" value="M" required="required">
				<label for="radio2">M </label>	
			</div>
			<div class="text-center">
				<button class="btn btn-secondary" type="submit">Enviar</button>
			</div>
		</div>
	</div>
</form>
