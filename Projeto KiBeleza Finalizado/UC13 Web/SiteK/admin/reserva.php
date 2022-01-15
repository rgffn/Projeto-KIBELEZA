<?php
//Permissões
 header("Access-Control-Allow-Origin: *");
 header("Content-Type: application/json; charset-UTF-8");
 header("Access-Control-Allow-Methods: POST, PUT, GET, OPTIONS, DELETE");
 
$data = file_get_contents('php://input');
$objData = json_decode($data);

$codFunc = $objData->codFunc;
$dataReserva = $objData->dataReserva;
$codServico = $objData->codServico;
$codCliente = $objData->codCliente;


$obs = '';
$horaReserva = date('G:i:s');
$status = 'AGUARDANDO';

//Remove as barras (\)
$codFunc = stripslashes($codFunc);
$dataReserva = stripslashes($dataReserva);
$codServico = stripslashes($codServico);
$codCliente = stripslashes($codCliente);

//Remove os espaços ( )
$codFunc = trim($codFunc);
$dataReserva = trim($dataReserva);
$codServico = trim($codServico);
$codCliente = trim($codCliente);

$dados;

        require_once("conexao.php");

        $conexao = Conexao::LigarConexao();
        $conexao->exec("SET NAMES utf8");

        if(($conexao) || ($codFunc !="")){
            $query = $conexao->prepare("INSERT INTO reserva (obs, dataReserva, horaReserva, status, idFuncionario, idCliente, idServico) VALUES ('".$obs."', '".$dataReserva."', '".$horaReserva."', '".$status."', '".$codFunc."', '".$codCliente."', '".$codServico."')");
            $query->execute();

            $dados = array('mensagem' => 'Dados inseridos com sucesso');

            echo json_encode($dados);
        
        }else{

            $dados = array('mensagem' => 'Não foi possivel inserir os dados.');

            echo json_encode($dados);
        }
?>