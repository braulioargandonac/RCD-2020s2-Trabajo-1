<!DOCTYPE html>
 <html lang="es">
 <head>
 <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Servicio Rest</title>
    <!-- Style -->
	<link rel="stylesheet" href="public/css/estilos.css">
	<link rel="stylesheet" href="public/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Poppins&display=swap" rel="stylesheet"> <!-- HAY QUE DESCARGAR ESTAS FUENTES -->
 </head>
<body>
	
	<?php include ("navegacion.php") ?>
	<section>
	<?php
	$paginaActual = new ControladorPlantilla();
	$paginaActual -> ctrControlarEnlaces();
	?>
	</section>

<script src="https://kit.fontawesome.com/35db202371.js" crossorigin="anonymous"></script>
<script src="public/js/app.js"></script>
 </body>
 </html>

