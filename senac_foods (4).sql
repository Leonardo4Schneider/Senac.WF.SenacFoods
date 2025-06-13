-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2025 at 02:46 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `senac_foods`
--

-- --------------------------------------------------------

--
-- Table structure for table `cardapio_item`
--

CREATE TABLE `cardapio_item` (
  `ID` int(11) NOT NULL,
  `TITULO` varchar(200) NOT NULL,
  `DESCRICAO` text NOT NULL,
  `PRECO` decimal(10,2) NOT NULL,
  `POSSUI_PREPARO` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cardapio_item`
--

INSERT INTO `cardapio_item` (`ID`, `TITULO`, `DESCRICAO`, `PRECO`, `POSSUI_PREPARO`) VALUES
(1, 'XIS SALADA', 'BIFE 180 G\r\nALFACE\r\nTOMATE\r\nQUEIJO CHEDDAR\r\nMAIONESE\r\nPÂO DE BRIOCHE', '25.00', 1),
(2, 'COCA COLA ORIGINAL 350ML', 'COCA COLA ORIGINAL 350ML', '5.00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `chefe_cozinha`
--

CREATE TABLE `chefe_cozinha` (
  `ID` int(11) NOT NULL,
  `COMANDA_ID` int(11) NOT NULL,
  `SITUACAO_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `comanda`
--

CREATE TABLE `comanda` (
  `ID` int(11) NOT NULL,
  `NUMERO_MESA` int(11) NOT NULL,
  `NOME_CLIENTE` varchar(150) NOT NULL,
  `SITUACAO_COMANDA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `comanda`
--

INSERT INTO `comanda` (`ID`, `NUMERO_MESA`, `NOME_CLIENTE`, `SITUACAO_COMANDA`) VALUES
(1, 100, 'JOÂO RODRIGUES\r\n', 1),
(2, 101, 'NATASHA SUAREZ', 1);

-- --------------------------------------------------------

--
-- Table structure for table `comanda_item`
--

CREATE TABLE `comanda_item` (
  `ID` int(11) NOT NULL,
  `CARDAPIO_ITEM_ID` int(11) NOT NULL,
  `COMANDA_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `comanda_item`
--

INSERT INTO `comanda_item` (`ID`, `CARDAPIO_ITEM_ID`, `COMANDA_ID`) VALUES
(1, 1, 1),
(2, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `mesa`
--

CREATE TABLE `mesa` (
  `ID` int(11) NOT NULL,
  `NUMERO_MESA` int(11) NOT NULL,
  `SITUACAO_MESA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mesa`
--

INSERT INTO `mesa` (`ID`, `NUMERO_MESA`, `SITUACAO_MESA`) VALUES
(1, 100, 1),
(2, 101, 1),
(3, 102, 0),
(4, 103, 0),
(5, 104, 0),
(6, 105, 0);

-- --------------------------------------------------------

--
-- Table structure for table `pedido_cozinha_item`
--

CREATE TABLE `pedido_cozinha_item` (
  `ID` int(11) NOT NULL,
  `PEDIDO_COZINHA_ID` int(11) NOT NULL,
  `COMANDA_ITEM_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) NOT NULL,
  `EMAIL` varchar(100) NOT NULL,
  `SENHA` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`ID`, `NOME`, `EMAIL`, `SENHA`) VALUES
(1, 'admin', 'admin@admin.com', '123'),
(2, 'leonardo', 'Leonardo@gmail', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cardapio_item`
--
ALTER TABLE `cardapio_item`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `chefe_cozinha`
--
ALTER TABLE `chefe_cozinha`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `comanda`
--
ALTER TABLE `comanda`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `comanda_item`
--
ALTER TABLE `comanda_item`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `mesa`
--
ALTER TABLE `mesa`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pedido_cozinha_item`
--
ALTER TABLE `pedido_cozinha_item`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cardapio_item`
--
ALTER TABLE `cardapio_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `chefe_cozinha`
--
ALTER TABLE `chefe_cozinha`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `comanda`
--
ALTER TABLE `comanda`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `comanda_item`
--
ALTER TABLE `comanda_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `mesa`
--
ALTER TABLE `mesa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `pedido_cozinha_item`
--
ALTER TABLE `pedido_cozinha_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
