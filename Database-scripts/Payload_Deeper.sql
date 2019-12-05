-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:59:17
-- Serverversion: 5.7.28-31-log
-- PHP-version: 7.2.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mikkelertbjerg_dk_db_ls`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `Payload_Deeper`
--

CREATE TABLE `Payload_Deeper` (
  `id` int(6) UNSIGNED NOT NULL,
  `depth_four_id` int(6) UNSIGNED NOT NULL,
  `depth_five_id` int(6) UNSIGNED NOT NULL,
  `depth_six_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Payload_Deeper`
--

INSERT INTO `Payload_Deeper` (`id`, `depth_four_id`, `depth_five_id`, `depth_six_id`) VALUES
(1, 26, 21, 60),
(2, 10, 56, 13),
(3, 93, 8, 95),
(4, 99, 56, 97),
(5, 13, 45, 83),
(6, 58, 63, 23),
(7, 47, 13, 31),
(8, 14, 56, 28),
(9, 63, 9, 100),
(10, 1, 38, 49),
(11, 64, 81, 67),
(12, 63, 99, 27),
(13, 37, 5, 18),
(14, 72, 9, 80),
(15, 57, 29, 36),
(16, 44, 70, 7),
(17, 35, 85, 29),
(18, 28, 23, 11),
(19, 63, 81, 31),
(20, 28, 55, 76),
(21, 37, 81, 84),
(22, 92, 12, 37),
(23, 9, 31, 24),
(24, 89, 24, 49),
(25, 16, 23, 54),
(26, 11, 10, 19),
(27, 59, 71, 51),
(28, 41, 81, 88),
(29, 30, 59, 3),
(30, 37, 19, 12),
(31, 96, 48, 34),
(32, 22, 85, 59),
(33, 36, 26, 77),
(34, 50, 26, 68),
(35, 46, 55, 6),
(36, 84, 95, 19),
(37, 37, 87, 34),
(38, 37, 4, 69),
(39, 27, 68, 72),
(40, 64, 38, 100),
(41, 81, 77, 6),
(42, 86, 98, 59),
(43, 58, 95, 36),
(44, 85, 43, 9),
(45, 74, 80, 46),
(46, 65, 69, 74),
(47, 53, 57, 10),
(48, 36, 18, 25),
(49, 66, 92, 54),
(50, 96, 85, 10),
(51, 93, 64, 61),
(52, 35, 17, 34),
(53, 30, 61, 100),
(54, 44, 40, 41),
(55, 60, 99, 64),
(56, 89, 60, 9),
(57, 35, 44, 97),
(58, 18, 38, 63),
(59, 24, 88, 56),
(60, 67, 39, 92),
(61, 96, 53, 53),
(62, 60, 79, 92),
(63, 82, 29, 83),
(64, 74, 92, 59),
(65, 11, 88, 23),
(66, 19, 21, 48),
(67, 81, 51, 95),
(68, 77, 91, 6),
(69, 98, 4, 26),
(70, 91, 66, 58),
(71, 44, 29, 70),
(72, 59, 54, 55),
(73, 97, 61, 26),
(74, 39, 6, 24),
(75, 5, 34, 55),
(76, 4, 18, 4),
(77, 19, 26, 88),
(78, 29, 7, 99),
(79, 1, 52, 80),
(80, 25, 36, 68),
(81, 95, 80, 67),
(82, 9, 77, 64),
(83, 10, 56, 76),
(84, 90, 34, 88),
(85, 65, 30, 63),
(86, 85, 82, 42),
(87, 22, 93, 7),
(88, 72, 37, 75),
(89, 86, 51, 40),
(90, 15, 41, 60),
(91, 6, 50, 47),
(92, 74, 96, 60),
(93, 6, 17, 31),
(94, 47, 43, 20),
(95, 7, 10, 34),
(96, 2, 11, 2),
(97, 36, 3, 5),
(98, 29, 10, 81),
(99, 22, 70, 16),
(100, 22, 79, 22);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Payload_Deeper`
--
ALTER TABLE `Payload_Deeper`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_dfo` (`depth_four_id`),
  ADD KEY `fk_dfi` (`depth_five_id`),
  ADD KEY `fk_si` (`depth_six_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Payload_Deeper`
--
ALTER TABLE `Payload_Deeper`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Payload_Deeper`
--
ALTER TABLE `Payload_Deeper`
  ADD CONSTRAINT `fk_dfi` FOREIGN KEY (`depth_five_id`) REFERENCES `Depth_Five` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_dfo` FOREIGN KEY (`depth_four_id`) REFERENCES `Depth_Four` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_si` FOREIGN KEY (`depth_six_id`) REFERENCES `Depth_Six` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
