<?php
require_once("conexao.php");
class Site{

    //atributos (variaveis)
    public $nome;
    public $email;
    public $fone;
    public $mens;
    public $data;
    public $hora;

    //metodos (funçoes)
	public function ListarBanner(){
		
		$query = "SELECT * FROM banner WHERE statusBanner = 1";
		$conexao = Conexao::LigarConexao();
		$conexao->exec("SET NAMES utf8");
		$resultado = $conexao->query($query);
		
		$lista = $resultado->fetchAll();
		return $lista;
		
	}
	
	//metodo para listar serviço
		public function ListarServico(){
		
		$query = "SELECT * FROM servico";
		$conexao = Conexao::LigarConexao();
		$conexao->exec("SET NAMES utf8");
		$resultado = $conexao->query($query);
		
		$lista = $resultado->fetchAll();
		return $lista;
	}
	//metodo para gravar contato no banco
	public function InserirContato(){
		$query = "INSERT INTO contato (nome, email, fone, mens, dataContato, horaContato) VALUES 
		('".$this->nome."','".$this->email."','".$this->fone."','".$this->mens."','".$this->data."',
		'".$this->hora."')";
		$conexao = Conexao::LigarConexao();
	}
	//metodo para listar as noticias
	
	
	//metodo para listar as equipes
			public function ListarEquipe(){
		
		$query = "SELECT * FROM funcionario";
		$conexao = Conexao::LigarConexao();
		$conexao->exec("SET NAMES utf8");
		$resultado = $conexao->query($query);
		
		$lista = $resultado->fetchAll();
		return $lista;
		}
}	//fim da classe site
?>