<div class="faixaServico wow fadeInUp">
		<section class="site corpoServico"><!-- SERVIÇO -->
			<h2>SERVIÇO</h2>
			<section>		
			<?php foreach(array_slice($listarServico, 0 , 4) as $linha): ?>	
				<article>
					<img src="../../ti07k/ti07k/admin/<?php echo $linha['fotoServico']?>" alt="<?php echo $linha['nomeServico'] ?>">
					<p><?php echo $linha['texto'] ?></p>
				</article>	
				<?php endforeach ?>
			</section>		
			<section>		
			<?php foreach(array_slice($listarServico, 4 , 8) as $linha): ?>	
				<article>
					<img src="../../ti07k/ti07k/admin/<?php echo $linha['fotoServico']?>" alt="<?php echo $linha['nomeServico'] ?>">
					<p><?php echo $linha['texto'] ?></p>
				</article>	
				<?php endforeach ?>
			</section>		
		</section><!-- FIM SERVIÇO -->
	</div>