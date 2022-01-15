<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}

$query = $conexao->prepare("SELECT * FROM banner ORDER BY idBanner ASC");

$query->execute();

$json = "[";

while ($resultado = $query->fetch()){

    if($json !="["){
        $json .= ",";
    }

    $json .= '{"codigo":"'.$resultado["idBanner"].'",';

    $json .= '"nome":"'.$resultado["nomeBanner"].'",';

    $json .= '"caminho":"'.$resultado["caminhoBanner"].'"}';

    //$json .= '"status":"'.$resultado["statusBanner"].'"}';
}
$json .= "]";
echo $json;
?>