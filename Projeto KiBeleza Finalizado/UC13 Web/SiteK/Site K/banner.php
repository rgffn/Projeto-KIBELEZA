	<section class="banner"><!-- Banner -->
	<?php foreach($listarBanner as $linha): ?>
		<img src="../../ti07k/ti07k/admin/<?php echo $linha['caminhoBanner']?>" alt="<?php echo $linha['nomeBanner'] ?>">
		<?php endforeach ?>
	</section><!-- Fim do Banner -->