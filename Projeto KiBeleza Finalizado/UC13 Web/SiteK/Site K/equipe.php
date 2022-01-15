		<section class="site corpoEquipe wow fadeInUp">
		<h2>EQUIPE</h2>
			<section>		
			<?php foreach(array_slice($listarEquipe, 0 , 4) as $linha): ?>	
				<article>
					<img src="../../ti07k/ti07k/admin/<?php echo $linha['fotoFunc']?>" alt="<?php echo $linha['nomeFunc'] ?>">
					<h3><?php echo $linha['nomeFunc'] ?></h3>
					<h4><?php echo $linha['nivelFunc'] ?></h4>
				</article>	
				<?php endforeach ?>
			</section>
			</section>