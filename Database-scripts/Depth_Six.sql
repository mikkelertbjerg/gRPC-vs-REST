-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:58:33
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
-- Struktur-dump for tabellen `Depth_Six`
--

CREATE TABLE `Depth_Six` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_five_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Six`
--

INSERT INTO `Depth_Six` (`id`, `string_value`, `int_value`, `double_value`, `depth_five_id`) VALUES
(1, 'ornare egestas ligula. Nullam', 78174, 8610, 69),
(2, 'ligula. Aliquam erat volutpat.', 12513, 48738, 25),
(3, 'vel est tempor bibendum.', 41497, 38132, 88),
(4, 'vestibulum massa rutrum magna.', 37152, 31548, 35),
(5, 'Morbi quis urna. Nunc', 52354, 74205, 73),
(6, 'ante, iaculis nec, eleifend', 90732, 78451, 48),
(7, 'malesuada augue ut lacus.', 77999, 34430, 47),
(8, 'eu erat semper rutrum.', 13014, 16222, 40),
(9, 'Phasellus at augue id', 42920, 18813, 22),
(10, 'Quisque libero lacus, varius', 8278, 77005, 96),
(11, 'quam dignissim pharetra. Nam', 96534, 6635, 8),
(12, 'dictum cursus. Nunc mauris', 76457, 80609, 38),
(13, 'facilisi. Sed neque. Sed', 81712, 93440, 36),
(14, 'dolor. Nulla semper tellus', 62970, 83193, 31),
(15, 'facilisis facilisis, magna tellus', 81835, 64279, 77),
(16, 'semper cursus. Integer mollis.', 45338, 62902, 67),
(17, 'varius orci, in consequat', 33138, 67390, 72),
(18, 'nec, euismod in, dolor.', 49716, 43084, 93),
(19, 'ornare, elit elit fermentum', 35049, 50665, 30),
(20, 'elit, pharetra ut, pharetra', 44212, 34882, 12),
(21, 'imperdiet dictum magna. Ut', 6237, 11305, 84),
(22, 'sit amet, risus. Donec', 63444, 23023, 46),
(23, 'a, malesuada id, erat.', 15553, 64927, 16),
(24, 'velit dui, semper et,', 12565, 30493, 11),
(25, 'Etiam imperdiet dictum magna.', 29515, 25745, 62),
(26, 'ipsum primis in faucibus', 3952, 82790, 75),
(27, 'magna, malesuada vel, convallis', 24713, 15193, 29),
(28, 'non, bibendum sed, est.', 18734, 26920, 88),
(29, 'ac tellus. Suspendisse sed', 55473, 90497, 67),
(30, 'vel pede blandit congue.', 76895, 58828, 75),
(31, 'molestie arcu. Sed eu', 34875, 41921, 27),
(32, 'metus. Vivamus euismod urna.', 57342, 93953, 72),
(33, 'aliquet magna a neque.', 91757, 1174, 77),
(34, 'fermentum metus. Aenean sed', 73822, 20387, 63),
(35, 'Phasellus at augue id', 88007, 62509, 61),
(36, 'viverra. Maecenas iaculis aliquet', 98208, 52844, 35),
(37, 'vitae purus gravida sagittis.', 35027, 21426, 67),
(38, 'malesuada fames ac turpis', 96729, 41976, 88),
(39, 'vestibulum, neque sed dictum', 99840, 35150, 58),
(40, 'metus vitae velit egestas', 16144, 18256, 40),
(41, 'netus et malesuada fames', 21960, 21265, 32),
(42, 'tellus eu augue porttitor', 79890, 49571, 45),
(43, 'Integer tincidunt aliquam arcu.', 75222, 70702, 26),
(44, 'auctor vitae, aliquet nec,', 55322, 15008, 59),
(45, 'Etiam vestibulum massa rutrum', 86311, 6669, 72),
(46, 'viverra. Donec tempus, lorem', 60423, 78948, 64),
(47, 'mi. Duis risus odio,', 73707, 76301, 17),
(48, 'nec, imperdiet nec, leo.', 88870, 41625, 56),
(49, 'dolor, nonummy ac, feugiat', 93813, 78529, 21),
(50, 'mattis velit justo nec', 84879, 73548, 38),
(51, 'eget lacus. Mauris non', 38115, 49805, 27),
(52, 'et, rutrum non, hendrerit', 67146, 32108, 3),
(53, 'imperdiet dictum magna. Ut', 71394, 2816, 48),
(54, 'Nunc mauris sapien, cursus', 72755, 70592, 76),
(55, 'molestie orci tincidunt adipiscing.', 31588, 82410, 81),
(56, 'malesuada augue ut lacus.', 87614, 89453, 88),
(57, 'Phasellus dapibus quam quis', 27102, 66325, 69),
(58, 'elementum purus, accumsan interdum', 27270, 44456, 78),
(59, 'Sed dictum. Proin eget', 9913, 49237, 47),
(60, 'pharetra ut, pharetra sed,', 49456, 37457, 19),
(61, 'enim. Suspendisse aliquet, sem', 41829, 13840, 99),
(62, 'facilisis vitae, orci. Phasellus', 31906, 30358, 14),
(63, 'velit dui, semper et,', 12592, 8250, 83),
(64, 'cursus a, enim. Suspendisse', 81421, 94103, 94),
(65, 'at fringilla purus mauris', 22294, 30292, 42),
(66, 'neque. Nullam ut nisi', 87456, 55788, 52),
(67, 'risus quis diam luctus', 60049, 4398, 63),
(68, 'lobortis risus. In mi', 93099, 79661, 97),
(69, 'lorem ipsum sodales purus,', 49221, 85975, 27),
(70, 'Fusce mi lorem, vehicula', 10287, 77977, 81),
(71, 'pharetra sed, hendrerit a,', 34442, 10545, 91),
(72, 'Donec porttitor tellus non', 68307, 13759, 72),
(73, 'sem semper erat, in', 94197, 64056, 13),
(74, 'tempor arcu. Vestibulum ut', 41892, 82545, 89),
(75, 'ligula. Nullam enim. Sed', 37421, 44614, 85),
(76, 'lobortis. Class aptent taciti', 33924, 19387, 17),
(77, 'Duis mi enim, condimentum', 37654, 8053, 67),
(78, 'mi tempor lorem, eget', 42658, 68014, 69),
(79, 'sit amet massa. Quisque', 58875, 62802, 64),
(80, 'neque vitae semper egestas,', 27125, 32034, 48),
(81, 'sit amet ante. Vivamus', 17294, 76707, 95),
(82, 'ac urna. Ut tincidunt', 60008, 33675, 87),
(83, 'nisi a odio semper', 41769, 84906, 92),
(84, 'venenatis lacus. Etiam bibendum', 6093, 21665, 59),
(85, 'nec mauris blandit mattis.', 20977, 55533, 91),
(86, 'Duis gravida. Praesent eu', 37364, 55958, 91),
(87, 'Quisque purus sapien, gravida', 19241, 95282, 22),
(88, 'auctor. Mauris vel turpis.', 44464, 5030, 93),
(89, 'ante dictum cursus. Nunc', 39917, 10046, 34),
(90, 'Suspendisse tristique neque venenatis', 49385, 37254, 96),
(91, 'Donec egestas. Duis ac', 50217, 95126, 29),
(92, 'sem ut dolor dapibus', 77448, 66689, 73),
(93, 'Etiam laoreet, libero et', 69253, 92908, 12),
(94, 'quis, pede. Praesent eu', 67374, 8186, 6),
(95, 'nulla. Integer vulputate, risus', 2206, 3735, 88),
(96, 'mollis. Phasellus libero mauris,', 96842, 14565, 48),
(97, 'amet massa. Quisque porttitor', 20947, 8809, 69),
(98, 'nulla. In tincidunt congue', 61409, 8244, 60),
(99, 'nec ligula consectetuer rhoncus.', 11794, 94343, 99),
(100, 'Lorem ipsum dolor sit', 18437, 94820, 60);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Six`
--
ALTER TABLE `Depth_Six`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_five` (`depth_five_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Six`
--
ALTER TABLE `Depth_Six`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Six`
--
ALTER TABLE `Depth_Six`
  ADD CONSTRAINT `fk_depth_five` FOREIGN KEY (`depth_five_id`) REFERENCES `Depth_Five` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
