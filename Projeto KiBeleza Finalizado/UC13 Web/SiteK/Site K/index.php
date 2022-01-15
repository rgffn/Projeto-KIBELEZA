<?php
require_once("header.php");
?>
<body><!-- CORPO -->
	<header class="topo"><!-- TOPO -->
		<div class="faixaRedeSocial">
			<div class="site topoRedeSocial"> <!-- TOPO CONTATO -->
				<h2>contato@kibeleza.com.br - (66) 66666-6666</h2>
				<ul>
					<li><a href="#"><img src="IMG/icon/face.svg" alt="Logo Facebook"></a></li>
					<li><a href="#"><img src="IMG/icon/insta.svg" alt="Logo Instagram"></a></li>
					<li><a href="#"><img src="IMG/icon/twitter.svg" alt="Logo Twttir"></a></li>
				</ul>
			</div>
		</div>
		<div class="faixaMenu"><!-- TOPO LOGO e MENU -->
			<div class="site topoRedeSocial">
				<h1 class="wow pulse"><a href="#">KiBeleza</a></h1>
				<nav class="menu">
					<ul>
						<li><a href="index.php">HOME</a></li>
						<li><a href="sobre.php">SOBRE</a></li>
						<li><a href="servico.php">SERVIÇO</a>
							<!--<ul class="sub-menu wow fadeInDown">
								<li><a href="#">SERVIÇO 1</a></li>
								<li><a href="#">SERVIÇO 2</a></li>
								<li><a href="#">SERVIÇO 3</a></li>
								<li><a href="#">SERVIÇO 4</a></li>
							</ul> -->
						</li>
						<li><a href="#">BLOG</a></li>
						<li><a href="contato.php">CONTATO</a></li>
					</ul>
				</nav>
			</div>
		</div>
	</header><!-- TOPO -->
	
	<!--<section class="banner"> BANNER
		<img src="IMG/banner.png" alt="Banner do site">
		<img src="IMG/banner.png" alt="Banner do site">
		<img src="IMG/banner.png" alt="Banner do site">
	</section> FIM BANNER -->

<?php
require_once("banner.php");
?>

	<section class="site corpoSobre wow bounceInUp" data-wow-duration='2s' data-wow-delay='1s'><!-- CORPO SOBRE -->
		<article>
			<h3 class="wow fadeInUp">Sobre</h3>
			<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
		</article>
		<article class="wow fadeInUp">
			<img src="IMG/sobre.png" alt="Sobre KiBeleza">
		</article>
	</section><!-- FIM CORPO SOBRE -->
	
	<section class="slider"> <!-- Insta -->
		<div class="slide-track" id="insta">
			
		</div>
	</section>	
	<!-- Fim do Insta -->

	<?php
	require_once("servicoline.php");
	?>

	<section class="destaque wow fadeInUp">
		<a href="//www.youtube.com/watch?v=XSGBVzeBUbk" data-lity>
			<img src="IMG/play.png" alt="Destaque">
		</a>
	</section>

	<?php
	require_once("equipe.php");
	?>
	
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
	<?php
	require_once("rodape.php");
	?>
</html>
