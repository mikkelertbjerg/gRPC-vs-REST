-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:59:21
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
-- Struktur-dump for tabellen `Payload_Deepest`
--

CREATE TABLE `Payload_Deepest` (
  `id` int(6) UNSIGNED NOT NULL,
  `depth_seven_id` int(6) UNSIGNED NOT NULL,
  `depth_eight_id` int(6) UNSIGNED NOT NULL,
  `depth_nine_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Payload_Deepest`
--

INSERT INTO `Payload_Deepest` (`id`, `depth_seven_id`, `depth_eight_id`, `depth_nine_id`) VALUES
(1, 91, 7, 56),
(2, 63, 78, 10),
(3, 58, 63, 63),
(4, 62, 28, 87),
(5, 65, 26, 97),
(6, 18, 97, 100),
(7, 34, 20, 28),
(8, 94, 88, 86),
(9, 69, 92, 89),
(10, 5, 24, 64),
(11, 39, 89, 10),
(12, 74, 4, 91),
(13, 51, 66, 19),
(14, 52, 99, 55),
(15, 83, 97, 67),
(16, 9, 23, 33),
(17, 70, 84, 18),
(18, 76, 10, 9),
(19, 100, 21, 93),
(20, 18, 93, 94),
(21, 38, 46, 53),
(22, 79, 82, 74),
(23, 19, 50, 4),
(24, 37, 99, 9),
(25, 71, 7, 10),
(26, 91, 79, 84),
(27, 25, 20, 99),
(28, 31, 33, 16),
(29, 64, 56, 11),
(30, 97, 72, 70),
(31, 96, 30, 14),
(32, 60, 77, 12),
(33, 15, 50, 57),
(34, 41, 90, 68),
(35, 82, 40, 51),
(36, 61, 9, 53),
(37, 25, 24, 62),
(38, 30, 11, 94),
(39, 33, 73, 16),
(40, 78, 87, 81),
(41, 78, 71, 85),
(42, 46, 72, 63),
(43, 93, 20, 65),
(44, 3, 77, 91),
(45, 66, 3, 8),
(46, 4, 55, 16),
(47, 62, 62, 54),
(48, 10, 35, 56),
(49, 48, 45, 6),
(50, 19, 10, 17),
(51, 37, 52, 24),
(52, 54, 15, 5),
(53, 97, 69, 9),
(54, 78, 13, 67),
(55, 4, 62, 51),
(56, 69, 72, 28),
(57, 98, 29, 86),
(58, 34, 59, 82),
(59, 7, 28, 78),
(60, 89, 97, 18),
(61, 24, 37, 48),
(62, 72, 37, 78),
(63, 29, 51, 89),
(64, 75, 33, 9),
(65, 2, 29, 36),
(66, 43, 11, 55),
(67, 41, 69, 65),
(68, 62, 22, 61),
(69, 15, 82, 9),
(70, 34, 47, 90),
(71, 14, 13, 65),
(72, 77, 91, 49),
(73, 58, 66, 69),
(74, 69, 81, 52),
(75, 10, 82, 79),
(76, 66, 78, 39),
(77, 80, 59, 90),
(78, 44, 83, 98),
(79, 17, 87, 36),
(80, 12, 38, 43),
(81, 23, 98, 84),
(82, 24, 92, 36),
(83, 28, 18, 36),
(84, 2, 18, 61),
(85, 70, 50, 50),
(86, 76, 81, 53),
(87, 35, 59, 84),
(88, 85, 29, 63),
(89, 40, 94, 76),
(90, 92, 45, 78),
(91, 38, 38, 14),
(92, 100, 52, 43),
(93, 99, 36, 25),
(94, 44, 94, 26),
(95, 64, 29, 80),
(96, 11, 42, 30),
(97, 85, 40, 74),
(98, 40, 61, 23),
(99, 24, 24, 19),
(100, 53, 41, 27);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Payload_Deepest`
--
ALTER TABLE `Payload_Deepest`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_dse` (`depth_seven_id`),
  ADD KEY `fk_de` (`depth_eight_id`),
  ADD KEY `fk_dn` (`depth_nine_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Payload_Deepest`
--
ALTER TABLE `Payload_Deepest`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Payload_Deepest`
--
ALTER TABLE `Payload_Deepest`
  ADD CONSTRAINT `fk_de` FOREIGN KEY (`depth_eight_id`) REFERENCES `Depth_Eight` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_dn` FOREIGN KEY (`depth_nine_id`) REFERENCES `Depth_Nine` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_dse` FOREIGN KEY (`depth_seven_id`) REFERENCES `Depth_Seven` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
