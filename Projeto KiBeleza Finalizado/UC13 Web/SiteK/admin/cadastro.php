<?php
//Permissões
 header("Access-Control-Allow-Origin: *");
 header("Content-Type: application/json; charset-UTF-8");
 header("Access-Control-Allow-Methods: POST, PUT, GET, OPTIONS, DELETE");


$data = file_get_contents('php://input');
$objData = json_decode($data);

$nome = $objData->nome;
$email = $objData->email;
$senha = $objData->senha;
//$senhaMd5 = md5($senha)
$status = 'ativo';
$dataCad = date('Y-m-d');
$foto = 'upload/cliente/user.png';

//Remove as barras
$nome = stripslashes($nome);
$email = stripslashes($email);
$senha = stripslashes($senha);

//Remove os espaços ( )
$nome = trim($nome);
$email = trim($email);
$senha = trim($senha);

$dados;

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if($conexao){

            $query = $conexao->prepare("INSERT INTO cliente (nomeCli, emailCli, senhaCli, statusCli, dataCadCli, fotoCli) VALUES ('".$nome."', '".$email."', '".$senha."', '".$status."', '".$dataCad."', '".$foto."');");
            $query->execute();

            $dados = array('mensagem' => 'Dados inseridos com sucesso');

            echo json_encode($dados);
        
        }else{

            $dados = array('mensagem' => 'Não foi possivel inserir os dados.');

            echo json_encode($dados);
        }
?>