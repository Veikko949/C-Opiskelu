-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 21.12.2020 klo 11:20
-- Palvelimen versio: 10.4.16-MariaDB
-- PHP Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csharp_hoteli`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `huone`
--

CREATE TABLE `huone` (
  `numero` int(11) NOT NULL,
  `tyyli` int(11) NOT NULL,
  `puhelin` varchar(100) NOT NULL,
  `vapaa` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huone`
--

INSERT INTO `huone` (`numero`, `tyyli`, `puhelin`, `vapaa`) VALUES
(1, 1, '124342221', 'Kyllä'),
(2, 4, '54312343', 'Kyllä');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet_katergoria`
--

CREATE TABLE `huoneet_katergoria` (
  `kategoria_id` int(11) NOT NULL,
  `etiketti` varchar(200) NOT NULL,
  `hinta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huoneet_katergoria`
--

INSERT INTO `huoneet_katergoria` (`kategoria_id`, `etiketti`, `hinta`) VALUES
(1, 'Yhden', '1000'),
(2, 'Kahden', '2000'),
(3, 'Perhe', '3000'),
(4, 'Sviitti', '5000');

-- --------------------------------------------------------

--
-- Rakenne taululle `kayttajat`
--

CREATE TABLE `kayttajat` (
  `id` int(11) DEFAULT NULL,
  `kayttaja` varchar(50) NOT NULL,
  `salasana` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `kayttajat`
--

INSERT INTO `kayttajat` (`id`, `kayttaja`, `salasana`) VALUES
(NULL, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Rakenne taululle `kayttajia`
--

CREATE TABLE `kayttajia` (
  `id` int(11) NOT NULL,
  `Etu_Nimi` varchar(100) NOT NULL,
  `Suku_Nimi` varchar(100) NOT NULL,
  `Puhelin` varchar(100) NOT NULL,
  `Maa` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `kayttajia`
--

INSERT INTO `kayttajia` (`id`, `Etu_Nimi`, `Suku_Nimi`, `Puhelin`, `Maa`) VALUES
(2, 'Tim', 'Tom', '6543124', 'Amerikka'),
(3, 'Moi', 'Tere', '54312354', 'Ruotsi');

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `varausID` int(11) NOT NULL,
  `huoneeNumero` int(11) NOT NULL,
  `asiakasID` int(11) NOT NULL,
  `paivaysSisaa` date NOT NULL,
  `paivaysUlos` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `varaukset`
--

INSERT INTO `varaukset` (`varausID`, `huoneeNumero`, `asiakasID`, `paivaysSisaa`, `paivaysUlos`) VALUES
(1, 1, 2, '2020-12-18', '2020-12-26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `huone`
--
ALTER TABLE `huone`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `fk_tyyli_id` (`tyyli`);

--
-- Indexes for table `huoneet_katergoria`
--
ALTER TABLE `huoneet_katergoria`
  ADD PRIMARY KEY (`kategoria_id`);

--
-- Indexes for table `kayttajia`
--
ALTER TABLE `kayttajia`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausID`),
  ADD KEY `fk_huone_numero` (`huoneeNumero`),
  ADD KEY `fk_asiakas_id` (`asiakasID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `huoneet_katergoria`
--
ALTER TABLE `huoneet_katergoria`
  MODIFY `kategoria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `kayttajia`
--
ALTER TABLE `kayttajia`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `huone`
--
ALTER TABLE `huone`
  ADD CONSTRAINT `fk_tyyli_id` FOREIGN KEY (`tyyli`) REFERENCES `huoneet_katergoria` (`kategoria_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Rajoitteet taululle `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_asiakas_id` FOREIGN KEY (`asiakasID`) REFERENCES `kayttajia` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_huone_numero` FOREIGN KEY (`huoneeNumero`) REFERENCES `huone` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
