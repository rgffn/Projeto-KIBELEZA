<?php
	require_once("../admin/site.php");
	$Site = new Site();
	$listarBanner = $Site->ListarBanner();
	
	$listarServico = $Site->ListarServico();
	$listarEquipe = $Site->ListarEquipe();

?>
<!doctype html>  <!-- Info pág HTML5 -->
<html lang="pt-br">

<head>
	<meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Home KiBeleza</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>	
	<link rel="stylesheet" type="text/css" href="CSS/reset.css">

	<!-- Banner Slick-->
	<link rel="stylesheet" type="text/css" href="CSS/slick.css">
    <link rel="stylesheet" type="text/css" href="CSS/slick-theme.css">
    <!-- Fim do Banner Slick-->

	<link rel="stylesheet" type="text/css" href="CSS/animate.css">
	<link rel="stylesheet" type="text/css" href="CSS/lity.css">

	<link rel="stylesheet" type="text/css" href="CSS/estilo.css">
	<link rel="stylesheet" type="text/css" href="CSS/anima.css">


</head>
