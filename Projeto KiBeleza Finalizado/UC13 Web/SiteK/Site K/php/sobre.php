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

	<!-- Zerar Site-->	
	<link rel="stylesheet" type="text/css" href="CSS/reset.css">
	<!-- Fim do Zerar Site -->

	<!-- Banner Slick -->
	<link rel="stylesheet" type="text/css" href="CSS/slick.css">
    <link rel="stylesheet" type="text/css" href="CSS/slick-theme.css">
    <!-- Fim do Banner Slick -->

	<!-- Animações -->
	<link rel="stylesheet" type="text/css" href="CSS/animate.css">
	<link rel="stylesheet" type="text/css" href="CSS/lity.css">
	<!--Fim das Animações -->

	<!-- Minhas Edições de Estilo -->
	<link rel="stylesheet" type="text/css" href="CSS/estilo.css">
	<link rel="stylesheet" type="text/css" href="CSS/anima.css">
	<!-- Fim das Minhas Edições de Estilo -->


</head>

<body><!-- Corpo do site -->
	<header class="topo"><!-- Topo do site -->
		<div class="faixaRedeSocial">
			<div class="site topoRedeSocial"> <!-- Topo do Contato -->
				<h2>contato@kibeleza.com.br (66) 66666-6666</h2>
				<ul>
					<li><a href="#"><img src="IMG/icon/face.svg" alt="Logo Facebook"></a></li>
					<li><a href="#"><img src="IMG/icon/insta.svg" alt="Logo Instagram"></a></li>
					<li><a href="#"><img src="IMG/icon/twitter.svg" alt="Logo Twttir"></a></li>
				</ul>
			</div>
		</div>
		<div class="faixaMenu menufa"> <!-- Topo da Logo e Menu -->
			<div class="site topoRedeSocial">
			<!-- Logo -->
				<h1 class="wow pulse"><a href="#">KiBeleza</a></h1>
			<!-- Fim do Logo-->
			<!-- Menu -->
				<button class="abrir-menu"></button>
			<nav class="menu">
				<button class="fechar-menu"></button>
				<ul>
					<li><a href="index.php">HOME</a></li>
					<li><a href="sobre.php">SOBRE</a></li>
					<li><a href="#">SERVIÇO</a>
						<!--<ul class="sub-menu wow fadeInDown">
							<li><a href="servico.php">SERVIÇO 1</a></li>
							<li><a href="#">SERVIÇO 2</a></li>
							<li><a href="#">SERVIÇO 3</a></li>
							<li><a href="#">SERVIÇO 4</a></li>
						</ul> -->
					</li>
					<li><a href="blog.php">BLOG</a></li>
					<li><a href="contato.php">CONTATO</a></li>
				</ul>
			</nav>
			<!-- Fim do Menu -->
		</div>
	</div>
</header><!-- Fim do Topo do Site -->
<?php
require_once("banner.php");
?>
	<!-- Corpo Sobre -->
	<section class="site corpoSobre wow bounceInUp" data-wow-duration='2s' data-wow-delay='1s'>
		<article>
			<h3 class="wow fadeInUp">Sobre</h3>
			<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
		</article>
		<article class="wow fadeInUp">
			<img src="IMG/sobre.png" alt="Sobre KiBeleza">
		</article>
	</section>
	<!-- Fim do Corpo Sobre -->

	<!-- Insta -->
	<section class="slider">
		<div class="slide-track" id="insta">
			
		</div>
	</section>	
	<!-- Fim do Insta -->
	
	<!-- Destaque -->
	<section class="destaque wow fadeInUp">
		<a href="//www.youtube.com/watch?v=XSGBVzeBUbk" data-lity>
			<img src="IMG/play.png" alt="Destaque">
		</a>
	</section>
	<!-- Fim do Destaque -->

	<!--Equipe-->
	<section class="site corpoEquipe wow fadeInUp">
		<h2>EQUIPE</h2>
		<section>
			<?php foreach(array_slice($listarEquipe, 0, 4) as $linha): ?>	
			<article>
			<img src="../admin/<?php echo $linha['fotoFunc'] ?>" alt="<?php echo $linha['nomeFunc']?>">
				<h3><?php echo $linha['nomeFunc']?></h3>
				<h4><?php echo $linha['nivelFunc']?></h4>
			</article>
			<?php endforeach?>
		</section>
	</section>
	<!-- Fim da Equipe -->
	
	<!-- Blog -->
	<div class="faixaBlog wow fadeInUp">
		<h2>BLOG</h2>
		<section class="blog site">
			<article>
				<img src="IMG/blog1.png" alt="Imagem do Blog">
				<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy textm has</p>
			</article>
			<article>
				<img src="IMG/blog2.png" alt="Imagem do Blog">
				<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy textm has</p>
			</article>
		</section>
	</div>
	<!-- Fim do Blog -->

	<!-- Rodapé -->
	<footer class="rodape wow fadeInUp">
		<img src="IMG/icon/logoKiBelezaBranco.svg">
		<ul>
			<li><a href="#"><img src="IMG/icon/faceBranco.svg"></a></li>
			<li><a href="#"><img src="IMG/icon/InstaBranco.svg" alt="Instagram"></a></li>
			<li><a href="#"><img src="IMG/icon/twitterBranco.svg" alt="Twitter"></a></li>
		</ul>
		<h2>contato@kibeleza.com.br</h2>
		<h2>(66) 66666-6666</h2>
		<h2>Todos os direitos reservados - TI07 | <a href="#">SENA SMP</a></h2>
	</footer>
	<!-- Fim do Rodapé-->

	<!--Recursos em JS-->
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/slick.js"></script>
	<script type="text/javascript" src="js/wow.js"></script>
	<script type="text/javascript" src="js/lity.js"></script>
	<!-- Fim dos Recursos em JS-->

	<!-- Edição de Recurso EM JS-->
	<script type="text/javascript" src="js/minhasAnimacoes.js"></script>
	<!-- Fim da Edição de Recurso em JS-->

<!-- Fim do Corpo -->
</html>
