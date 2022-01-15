<?php
    header("Access-Control-Allow-Origin: *");

    class Conexao{
    
        public static function LigarConexao(){
            $conn = new PDO("mysql:host=localhost;dbname=kibeleza","root",""); //dbname= 'Nome do seu banco'
            return $conn;
        }
    }
?>