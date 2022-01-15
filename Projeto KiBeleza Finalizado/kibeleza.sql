-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Jul-2021 às 23:06
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `kibeleza`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `banner`
--

CREATE TABLE `banner` (
  `idBanner` int(11) NOT NULL,
  `nomeBanner` varchar(100) NOT NULL,
  `caminhoBanner` varchar(100) NOT NULL,
  `statusBanner` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `banner`
--

INSERT INTO `banner` (`idBanner`, `nomeBanner`, `caminhoBanner`, `statusBanner`) VALUES
(2, 'BANNER', 'upload/banner/banner.png', 1),
(3, 'banner2', 'upload/banner/banner2.png', 1),
(4, 'banner3', 'upload/banner/banner3.png', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `nomeCli` varchar(100) NOT NULL,
  `emailCli` varchar(100) NOT NULL,
  `senhaCli` varchar(45) NOT NULL,
  `statusCli` varchar(45) NOT NULL,
  `dataCadCli` datetime NOT NULL,
  `fotoCli` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`idCliente`, `nomeCli`, `emailCli`, `senhaCli`, `statusCli`, `dataCadCli`, `fotoCli`) VALUES
(65, 'VINI', 'vini@gmail.com', '123', 'ATIVO', '2021-04-27 00:00:00', 'upload/cliente/96655b5738f8b1791c452a8e218a0c83.png'),
(67, 'BERTA', 'berta@gmail.com', '123', 'ATIVO', '2021-05-03 00:00:00', 'upload/cliente/user.png'),
(68, 'BIBI', 'bibi@gmail.com', '123', 'ATIVO', '2021-05-03 00:00:00', 'upload/cliente/40+ Dark Wallpapers.jpg'),
(69, 'DAYLLON', 'day@gmail.com', '123', 'ATIVO', '2021-05-03 00:00:00', 'upload/cliente/banner11.png'),
(70, 'VAL', 'val@gmail.com', '123', 'INATIVO', '2021-05-03 00:00:00', 'upload/cliente/destaque (2).png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `contato`
--

CREATE TABLE `contato` (
  `id` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `email` varchar(150) NOT NULL,
  `assunto` varchar(100) NOT NULL,
  `fone` varchar(20) NOT NULL,
  `mens` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `contato`
--

INSERT INTO `contato` (`id`, `nome`, `email`, `assunto`, `fone`, `mens`) VALUES
(16, 'val', 'val@gmail.com', 'explicação', '111111111', 'me mudei');

-- --------------------------------------------------------

--
-- Estrutura da tabela `empresa`
--

CREATE TABLE `empresa` (
  `idEmpresa` int(11) NOT NULL,
  `nomeEmp` varchar(100) NOT NULL,
  `cnpjCpfEmp` varchar(45) NOT NULL,
  `razaoSocialEmp` varchar(100) NOT NULL,
  `emailEmp` varchar(100) NOT NULL,
  `statusEmp` varchar(45) NOT NULL,
  `dataCadEmp` date NOT NULL,
  `horarioAtendEmp` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `empresa`
--

INSERT INTO `empresa` (`idEmpresa`, `nomeEmp`, `cnpjCpfEmp`, `razaoSocialEmp`, `emailEmp`, `statusEmp`, `dataCadEmp`, `horarioAtendEmp`) VALUES
(1, 'KiBeleza', '11.212.112/3123-12', 'Lorem Ipsum is simply dummy text of the printing and typesetting industry.', 'kibeleza@gmail.com', 'ATIVO', '2021-01-27', '11:00:00'),
(2, 'KiBeleza Estética', '999', 'Lorem Ipsum is simply dummy text of the printing and typesetting industry.', 'kibe@gmail.com', 'ATIVO', '2020-12-01', '12:00:00'),
(3, 'KiBeleza Filial', '999', 'Lorem Ipsum is simply dummy text of the printing.', 'kibf@gmail.com', 'ATIVO', '2020-09-30', '06:00:00'),
(5, 'KiBeleza do Paraguai', '61.616.161/6161-61', 'KIBELEZA do Paraguai LTDA ', 'kibdoparaguai@gmail.com', 'INATIVO', '2021-02-12', '12:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fonecli`
--

CREATE TABLE `fonecli` (
  `idFoneCli` int(11) NOT NULL,
  `numeroCliente` varchar(45) NOT NULL,
  `tipoFoneCli` varchar(45) NOT NULL,
  `descFoneCli` varchar(45) NOT NULL,
  `idCliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fonecli`
--

INSERT INTO `fonecli` (`idFoneCli`, `numeroCliente`, `tipoFoneCli`, `descFoneCli`, `idCliente`) VALUES
(26, '(11) 99999-9999', 'CELULAR', 'VIVO', 65),
(27, '(11) 11111-1111', 'CELULAR', 'CLARO', 67),
(28, '(11) 33333-3333', 'FIXO', 'VIVO', 68),
(29, '(11) 55555-5555', 'FIXO', 'TIM', 69);

-- --------------------------------------------------------

--
-- Estrutura da tabela `foneemp`
--

CREATE TABLE `foneemp` (
  `idFoneEmp` int(11) NOT NULL,
  `numeroEmp` varchar(45) NOT NULL,
  `tipoFoneEmp` varchar(45) NOT NULL,
  `descFoneEmp` varchar(45) NOT NULL,
  `idEmpresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `foneemp`
--

INSERT INTO `foneemp` (`idFoneEmp`, `numeroEmp`, `tipoFoneEmp`, `descFoneEmp`, `idEmpresa`) VALUES
(1, '97572-2397', 'CELULAR', 'CLARO', 2),
(2, '7528-2397', 'FIXO', 'OI', 2),
(3, '97522-2197', 'CELULAR', 'TIM', 3),
(4, '7522-2397', 'FIXO', 'VIVO', 3),
(7, '(69) 95956-0046', 'TIM', 'CELULAR', 1),
(8, '(11) 95956-0046', 'TIM', 'CELULAR', 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `fonefunc`
--

CREATE TABLE `fonefunc` (
  `idFoneFunc` int(11) NOT NULL,
  `numeroFunc` varchar(45) NOT NULL,
  `tipoFoneFunc` varchar(45) NOT NULL,
  `descFoneFunc` varchar(45) NOT NULL,
  `idFuncionario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fonefunc`
--

INSERT INTO `fonefunc` (`idFoneFunc`, `numeroFunc`, `tipoFoneFunc`, `descFoneFunc`, `idFuncionario`) VALUES
(24, '(77) 76666-6666', 'CELULAR', 'VIVO', 29),
(25, '(55) 55555-5555', 'CELULAR', 'CLARO', 30),
(26, '(77) 77777-9999', 'FIXO', 'OI', 31),
(27, '(22) 32323-2323', 'CELULAR', 'VIVO', 32),
(28, '(55) 55555-5555', 'CELULAR', 'CLARO', 33),
(29, '(11) 11111-1111', 'CELULAR', 'CLARO', 34);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `idFuncionario` int(11) NOT NULL,
  `nomeFunc` varchar(100) NOT NULL,
  `emailFunc` varchar(100) NOT NULL,
  `senhaFunc` varchar(45) NOT NULL,
  `nivelFunc` varchar(45) NOT NULL,
  `statusFunc` varchar(45) NOT NULL,
  `dataCadFunc` date NOT NULL,
  `horarioTrabalhoFunc` time NOT NULL,
  `fotoFunc` varchar(100) NOT NULL,
  `idEmpresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`idFuncionario`, `nomeFunc`, `emailFunc`, `senhaFunc`, `nivelFunc`, `statusFunc`, `dataCadFunc`, `horarioTrabalhoFunc`, `fotoFunc`, `idEmpresa`) VALUES
(29, 'FRANCHESKA', 'fran@gmail.com', '123', 'ATENDENTE', 'ATIVO', '2021-05-02', '08:00:00', 'upload/funcionario/69747392_2420790401529829_8390119214307868672_n.jpg', 1),
(30, 'BITUCA', 'bit@gmail.com', '123', 'ATENDENTE', 'ATIVO', '2021-05-02', '08:00:00', 'upload/funcionario/4beb34a8379a5a20d3ee98917cc0613a.png', 2),
(31, 'ALAN', 'alan@gmail.com', '123', 'ATENDENTE', 'ATIVO', '2021-05-02', '08:00:00', 'upload/funcionario/MicrosoftTeams-image.png', 3),
(32, 'ROBYNSOM', 'rob@gmail.com', '123', 'ADMINISTRADOR', 'ATIVO', '2021-05-02', '10:00:00', 'upload/funcionario/MicrosoftTeams-image (1).png', 2),
(33, 'CLAHRICY', 'cla@gmail.com', '123', 'ATENDENTE', 'ATIVO', '2021-05-02', '08:00:00', 'upload/funcionario/121787889_2775044692771063_5871713770823236090_n.jpg', 3),
(34, 'CARECA DONO DE TUDO', 'c@gmail.com', '123', 'ADMINISTRADOR', 'ATIVO', '2021-05-02', '10:00:00', 'upload/funcionario/MicrosoftTeams-image (2).png', 1),
(35, 'FVF', 'dzcd@gmail.com', '123', 'ADMINISTRADOR', 'ATIVO', '2021-07-29', '01:00:00', 'upload/funcionario/MicrosoftTeams-image (1).png', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `horariosreserva`
--

CREATE TABLE `horariosreserva` (
  `idHorarioReserva` int(11) NOT NULL,
  `horarioReserva` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `horariosreserva`
--

INSERT INTO `horariosreserva` (`idHorarioReserva`, `horarioReserva`) VALUES
(1, '08:00:00'),
(2, '08:30:00'),
(4, '09:00:00'),
(5, '09:30:00'),
(6, '10:00:00'),
(7, '10:30:00'),
(8, '11:00:00'),
(9, '11:30:00'),
(10, '12:00:00'),
(12, '13:30:00'),
(13, '14:00:00'),
(14, '14:30:00'),
(15, '15:00:00'),
(16, '15:30:00'),
(17, '16:00:00'),
(18, '16:30:00'),
(19, '17:00:00'),
(20, '17:30:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `reserva`
--

CREATE TABLE `reserva` (
  `idReserva` int(11) NOT NULL,
  `obs` text NOT NULL,
  `dataReserva` datetime NOT NULL,
  `horaReserva` datetime NOT NULL,
  `status` varchar(45) NOT NULL,
  `idFuncionario` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `idServico` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

CREATE TABLE `servico` (
  `idServico` int(11) NOT NULL,
  `nomeServico` varchar(100) NOT NULL,
  `valorServico` decimal(10,2) NOT NULL,
  `statusServico` varchar(45) NOT NULL,
  `dataCadServico` date NOT NULL,
  `fotoServico` varchar(250) NOT NULL,
  `fotoServico1` varchar(250) NOT NULL,
  `fotoServico2` varchar(250) NOT NULL,
  `fotoServico3` varchar(250) NOT NULL,
  `descServico` text NOT NULL,
  `texto` text NOT NULL,
  `tempoServico` time NOT NULL,
  `idEmpresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servico`
--

INSERT INTO `servico` (`idServico`, `nomeServico`, `valorServico`, `statusServico`, `dataCadServico`, `fotoServico`, `fotoServico1`, `fotoServico2`, `fotoServico3`, `descServico`, `texto`, `tempoServico`, `idEmpresa`) VALUES
(23, 'DEPILAÇÃO', '50.00', 'ATIVO', '2021-04-16', 'upload/servico/insta01.png', 'upload/servico/ADMPOD.PNG', 'upload/servico/foto1.png', 'upload/servico/banner3.png', 'C/ USO DE LASER', 'DEPILAÇÃO SIMPLES', '01:00:00', 1),
(24, 'CORTE SIMPLES', '30.00', 'ATIVO', '2021-04-16', 'upload/servico/destaque (2).png', 'upload/servico/destaque (2).png', 'upload/servico/destaque (2).png', 'upload/servico/destaque (2).png', 'CORTE SIMPLES', 'CORTE SIMPLES', '01:00:00', 1),
(26, 'MASSAGEM', '20.00', 'ATIVO', '2021-04-16', 'upload/servico/insta01.png', 'upload/servico/insta01.png', 'upload/servico/insta01.png', 'upload/servico/insta01.png', 'MASSAGEM SIMPLES', 'C/ OLÉO', '00:30:00', 1),
(27, 'SOMBRANCELHA ', '10.00', 'ATIVO', '2021-04-16', 'upload/servico/slide.png', 'upload/servico/slide.png', 'upload/servico/slide.png', 'upload/servico/slide.png', 'SOMBRANCELHA', 'REPARAÇÃO E AJUSTE', '00:30:00', 1),
(29, 'CORTE AVANÇADO', '60.00', 'ATIVO', '2021-05-02', 'upload/servico/destaque (3).png', 'upload/servico/foto.png', 'upload/servico/insta01.png', 'upload/servico/foto2.png', 'CORTE AVANÇADO COM PENTEADO', 'USO DE SECADOR E LAVAGEM', '01:30:00', 2),
(30, 'COLORAÇÃO', '35.00', 'ATIVO', '2021-05-02', 'upload/servico/destaque (2).png', 'upload/servico/foto3.png', 'upload/servico/insta03.png', 'upload/servico/foto.png', 'TINGIMENTO', 'CORES UNÍCAS, ESCOLHA DO CLIENTE.', '02:00:00', 3),
(31, 'TRATAMENTO ANTI QUEDA', '70.00', 'ATIVO', '2021-05-02', 'upload/servico/banner1.png', 'upload/servico/insta01.png', 'upload/servico/slide3 (3).png', 'upload/servico/121787889_2775044692771063_5871713770823236090_n.jpg', 'TRATAMENTO INTENSIVO', 'PREVINE A QUEDA DE CABELO', '02:00:00', 2),
(32, 'PROGRESSIVA', '100.00', 'ATIVO', '2021-05-02', 'upload/servico/slide3 (3).png', 'upload/servico/clienteADMPOD (2).png', 'upload/servico/destaque.png', 'upload/servico/slide3 (1).png', 'A MELHOR DA REGIÃO', 'RESULTADOS SURPREENDENTES!', '02:30:00', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `banner`
--
ALTER TABLE `banner`
  ADD PRIMARY KEY (`idBanner`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Índices para tabela `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`idEmpresa`);

--
-- Índices para tabela `fonecli`
--
ALTER TABLE `fonecli`
  ADD PRIMARY KEY (`idFoneCli`),
  ADD KEY `idCliente` (`idCliente`);

--
-- Índices para tabela `foneemp`
--
ALTER TABLE `foneemp`
  ADD PRIMARY KEY (`idFoneEmp`),
  ADD KEY `foneemp_ibfk_1` (`idEmpresa`);

--
-- Índices para tabela `fonefunc`
--
ALTER TABLE `fonefunc`
  ADD PRIMARY KEY (`idFoneFunc`),
  ADD KEY `idFuncionario` (`idFuncionario`);

--
-- Índices para tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`idFuncionario`),
  ADD KEY `idEmpresa` (`idEmpresa`);

--
-- Índices para tabela `horariosreserva`
--
ALTER TABLE `horariosreserva`
  ADD PRIMARY KEY (`idHorarioReserva`);

--
-- Índices para tabela `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`idReserva`),
  ADD KEY `idFuncionario` (`idFuncionario`),
  ADD KEY `idCliente` (`idCliente`),
  ADD KEY `idServico` (`idServico`);

--
-- Índices para tabela `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`idServico`),
  ADD KEY `idEmpresa` (`idEmpresa`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `banner`
--
ALTER TABLE `banner`
  MODIFY `idBanner` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT de tabela `contato`
--
ALTER TABLE `contato`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `empresa`
--
ALTER TABLE `empresa`
  MODIFY `idEmpresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `fonecli`
--
ALTER TABLE `fonecli`
  MODIFY `idFoneCli` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de tabela `foneemp`
--
ALTER TABLE `foneemp`
  MODIFY `idFoneEmp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `fonefunc`
--
ALTER TABLE `fonefunc`
  MODIFY `idFoneFunc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `idFuncionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT de tabela `horariosreserva`
--
ALTER TABLE `horariosreserva`
  MODIFY `idHorarioReserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `reserva`
--
ALTER TABLE `reserva`
  MODIFY `idReserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT de tabela `servico`
--
ALTER TABLE `servico`
  MODIFY `idServico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `fonecli`
--
ALTER TABLE `fonecli`
  ADD CONSTRAINT `fonecli_ibfk_1` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`);

--
-- Limitadores para a tabela `foneemp`
--
ALTER TABLE `foneemp`
  ADD CONSTRAINT `foneemp_ibfk_1` FOREIGN KEY (`idEmpresa`) REFERENCES `empresa` (`idEmpresa`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `fonefunc`
--
ALTER TABLE `fonefunc`
  ADD CONSTRAINT `fonefunc_ibfk_1` FOREIGN KEY (`idFuncionario`) REFERENCES `funcionario` (`idFuncionario`);

--
-- Limitadores para a tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`idEmpresa`) REFERENCES `empresa` (`idEmpresa`);

--
-- Limitadores para a tabela `reserva`
--
ALTER TABLE `reserva`
  ADD CONSTRAINT `reserva_ibfk_1` FOREIGN KEY (`idFuncionario`) REFERENCES `funcionario` (`idFuncionario`),
  ADD CONSTRAINT `reserva_ibfk_2` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`),
  ADD CONSTRAINT `reserva_ibfk_3` FOREIGN KEY (`idServico`) REFERENCES `servico` (`idServico`);

--
-- Limitadores para a tabela `servico`
--
ALTER TABLE `servico`
  ADD CONSTRAINT `servico_ibfk_1` FOREIGN KEY (`idEmpresa`) REFERENCES `empresa` (`idEmpresa`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
