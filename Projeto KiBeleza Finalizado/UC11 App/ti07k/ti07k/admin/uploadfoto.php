<?php
//Permissões
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: POST, PUT, GET, OPTIONS, DELETE, PATCH");
header("Access-Control-Max-Age: 86400");
header("Access-Control-Expose-Header: Content-Lenght, X-JSON");
header("Access-Control-Allow-Headers: *");

$data = file_get_contents('php://input');
$objData = json_decode($data);

$foto = $objData->foto;
$codigoCli = $objData->codigoCli;

if(!$foto){
    return false;
}

$nomeFoto = md5(uniqid(rand(), true)); //Criar nome de foto aleatório
$nomeArquivo = $nomeFoto.'.png';
$caminhoArquivo = 'upload/cliente/';

$dadosDaFoto = base64_decode($foto, true);

if(!$dadosDaFoto){
    $encodeData = base64_encode(file_get_contents($foto));
    $dadosDaFoto = base64_decode($encodeData);
}

$dados;

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if($conexao){

            $Sql = "UPDATE cliente SET fotoCli = 'upload/cliente/".$nomeArquivo."' WHERE idCliente = $codigoCli";

            $endFotoBanco = 'upload/cliente/'.$nomeArquivo;

            $query = $conexao->prepare($Sql);
            $query->execute();

            $dados = array('nomeImagem' => $endFotoBanco);

            echo json_encode($dados);
        
        }else{

            $dados = array('mensagem' => 'Não foi possivel adicionar a foto.');

            echo json_encode($dados);
        }

        return file_put_contents($caminhoArquivo . $nomeArquivo, $dadosDaFoto);
?>