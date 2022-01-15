<?php
//Permissões
 header("Access-Control-Allow-Origin: *");
 header("Content-Type: application/json; charset-UTF-8");
 header("Access-Control-Allow-Methods: POST, PUT, GET, OPTIONS, DELETE");


$data = file_get_contents('php://input');
$objData = json_decode($data);

$codigo = $objData->codigo;
$nome = $objData->nome;
$email = $objData->email;
$senha = $objData->senha;
//$senhaMd5 = md5($senha)
$status = 'ativo';
$dataCad = date('Y-m-d');
$foto = 'upload/cliente/user.png';

//Remove as barras
$codigo = stripslashes($codigo);
$nome = stripslashes($nome);
$email = stripslashes($email);
$senha = stripslashes($senha);

//Remove os espaços ( )
$codigo = trim($codigo);
$nome = trim($nome);
$email = trim($email);
$senha = trim($senha);

$dados;

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if($conexao){

            $query = $conexao->prepare("update cliente SET nomeCli = '$nome', emailCli = '$email', senhaCli = '$senha' WHERE cliente.idCliente = $codigo");
            $query->execute();

            $dados = array('mensagem' => 'Dados inseridos com sucesso');

            echo json_encode($dados);
        
        }else{

            $dados = array('mensagem' => 'Não foi possivel inserir os dados.');

            echo json_encode($dados);
        }
?>