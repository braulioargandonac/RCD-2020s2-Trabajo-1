<br><br>
<form method='post'>
	<div class="container mx-auto mt-5 pt-5">
		<div class="form-group cardinicio px-5 shadow p-3 mb-5 rounded">
			<h1>Rut</h1>
			<p>ingrese su rut sin puntos y con "-" tal y como aparece en el ejemplo<br> el servicio comprobara si su dígito verificador es valido o no</p>
			<label for="rut">Ingrese rut:</label>
			<input type="text" required="required" pattern="[0-9]{7,8}-[0-9Kk]{1}" class="form-control" name="rut" id="rut" placeholder="123456789-5" title="ej. 12345678-5"><br>				
			<div class="text-center">
				<button class="btn btn-secondary" type="submit">Enviar</button><br>
			</div>
		</div>
	</div>
	
<div class="container px-5">
	<?php 
		if($_POST){
			$respuesta = new ControladorPlantilla();
			$respuesta -> ctrRut();
		}		
	?>		
</div>