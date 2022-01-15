<?php

require_once("conexao.php");

$conexao = Conexao::LigarConexao();
$conexao->exec("SET NAMES utf8");

if(!$conexao){

    echo "Não esta conectado ao banco";

}

$query = $conexao->prepare("SELECT * FROM funcionario WHERE statusFunc = 'ATIVO' AND nivelFunc='ATENDENTE' ORDER BY nomeFunc ASC");

$query->execute();

$json = "[";

while ($resultado = $query->fetch()){ 

    if($json !="["){
        $json .= ",";
    }

    $json .= '{"idFuncionario":"'.$resultado["idFuncionario"].'",';

    $json .= '"nomeFunc":"'.$resultado["nomeFunc"].'",';

    $json .= '"emailFunc":"'.$resultado["emailFunc"].'",';

    $json .= '"statusFunc":"'.$resultado["statusFunc"].'"}';
}
$json .= "]";
echo $json;
?>