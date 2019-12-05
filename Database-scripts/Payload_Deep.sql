-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:59:12
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
-- Struktur-dump for tabellen `Payload_Deep`
--

CREATE TABLE `Payload_Deep` (
  `id` int(6) UNSIGNED NOT NULL,
  `depth_one_id` int(6) UNSIGNED NOT NULL,
  `depth_two_id` int(6) UNSIGNED NOT NULL,
  `depth_three_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Payload_Deep`
--

INSERT INTO `Payload_Deep` (`id`, `depth_one_id`, `depth_two_id`, `depth_three_id`) VALUES
(1, 70, 56, 98),
(2, 48, 51, 92),
(3, 52, 26, 43),
(4, 38, 7, 92),
(5, 63, 65, 75),
(6, 27, 89, 67),
(7, 78, 52, 21),
(8, 36, 65, 83),
(9, 83, 90, 81),
(10, 50, 1, 95),
(11, 65, 44, 76),
(12, 84, 79, 20),
(13, 9, 93, 10),
(14, 88, 89, 49),
(15, 84, 42, 45),
(16, 72, 7, 4),
(17, 32, 34, 62),
(18, 63, 89, 9),
(19, 1, 69, 95),
(20, 89, 35, 18),
(21, 69, 25, 88),
(22, 76, 43, 40),
(23, 31, 91, 73),
(24, 52, 86, 2),
(25, 96, 7, 71),
(26, 6, 59, 63),
(27, 79, 79, 9),
(28, 61, 60, 35),
(29, 32, 73, 84),
(30, 45, 18, 41),
(31, 17, 47, 68),
(32, 44, 35, 24),
(33, 84, 9, 45),
(34, 42, 19, 10),
(35, 7, 74, 89),
(36, 82, 16, 61),
(37, 58, 42, 2),
(38, 48, 88, 68),
(39, 66, 73, 16),
(40, 99, 63, 77),
(41, 41, 99, 12),
(42, 12, 93, 48),
(43, 28, 28, 78),
(44, 93, 95, 63),
(45, 78, 73, 6),
(46, 79, 82, 10),
(47, 52, 26, 41),
(48, 1, 70, 83),
(49, 76, 94, 61),
(50, 79, 63, 97),
(51, 71, 11, 56),
(52, 13, 39, 93),
(53, 84, 58, 29),
(54, 20, 5, 78),
(55, 93, 71, 96),
(56, 58, 67, 90),
(57, 95, 28, 59),
(58, 42, 54, 64),
(59, 84, 26, 34),
(60, 59, 5, 68),
(61, 16, 71, 66),
(62, 74, 13, 54),
(63, 84, 61, 64),
(64, 99, 71, 62),
(65, 47, 89, 89),
(66, 48, 83, 45),
(67, 37, 29, 19),
(68, 66, 72, 68),
(69, 63, 46, 69),
(70, 82, 34, 49),
(71, 44, 79, 85),
(72, 11, 42, 10),
(73, 92, 92, 18),
(74, 69, 18, 59),
(75, 57, 40, 97),
(76, 96, 50, 31),
(77, 87, 4, 62),
(78, 45, 15, 22),
(79, 98, 80, 24),
(80, 85, 18, 91),
(81, 74, 36, 34),
(82, 89, 89, 46),
(83, 25, 54, 26),
(84, 54, 42, 8),
(85, 18, 88, 76),
(86, 90, 41, 57),
(87, 13, 99, 90),
(88, 99, 50, 11),
(89, 20, 58, 27),
(90, 4, 37, 68),
(91, 61, 21, 12),
(92, 96, 80, 92),
(93, 93, 37, 12),
(94, 57, 43, 27),
(95, 93, 46, 41),
(96, 13, 36, 21),
(97, 81, 61, 100),
(98, 69, 64, 46),
(99, 100, 5, 97),
(100, 3, 19, 69);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Payload_Deep`
--
ALTER TABLE `Payload_Deep`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_do` (`depth_one_id`),
  ADD KEY `fk_dto` (`depth_two_id`),
  ADD KEY `fk_dte` (`depth_three_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Payload_Deep`
--
ALTER TABLE `Payload_Deep`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Payload_Deep`
--
ALTER TABLE `Payload_Deep`
  ADD CONSTRAINT `fk_do` FOREIGN KEY (`depth_one_id`) REFERENCES `Depth_One` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_dte` FOREIGN KEY (`depth_three_id`) REFERENCES `Depth_Three` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_dto` FOREIGN KEY (`depth_two_id`) REFERENCES `Depth_Two` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
