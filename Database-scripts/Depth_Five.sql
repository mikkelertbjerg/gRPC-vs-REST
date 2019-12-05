-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:58:23
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
-- Struktur-dump for tabellen `Depth_Five`
--

CREATE TABLE `Depth_Five` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_four_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Five`
--

INSERT INTO `Depth_Five` (`id`, `string_value`, `int_value`, `double_value`, `depth_four_id`) VALUES
(1, 'imperdiet dictum magna. Ut', 13145, 56546, 67),
(2, 'placerat, augue. Sed molestie.', 50583, 40867, 89),
(3, 'nec, cursus a, enim.', 46309, 21546, 22),
(4, 'dis parturient montes, nascetur', 97195, 83129, 16),
(5, 'natoque penatibus et magnis', 35761, 22971, 12),
(6, 'libero est, congue a,', 34802, 35079, 63),
(7, 'dolor. Quisque tincidunt pede', 59301, 94484, 31),
(8, 'ac, fermentum vel, mauris.', 25179, 75422, 41),
(9, 'ac sem ut dolor', 79103, 39665, 94),
(10, 'tempus, lorem fringilla ornare', 29752, 61157, 98),
(11, 'Vivamus nibh dolor, nonummy', 88263, 55947, 6),
(12, 'tellus faucibus leo, in', 17348, 19100, 67),
(13, 'et malesuada fames ac', 50266, 87810, 3),
(14, 'Cras pellentesque. Sed dictum.', 91500, 21692, 89),
(15, 'risus odio, auctor vitae,', 76718, 95615, 35),
(16, 'erat eget ipsum. Suspendisse', 43862, 63181, 4),
(17, 'nec, euismod in, dolor.', 51209, 96606, 75),
(18, 'parturient montes, nascetur ridiculus', 70955, 44163, 17),
(19, 'amet, consectetuer adipiscing elit.', 50108, 87103, 1),
(20, 'diam lorem, auctor quis,', 31040, 90692, 29),
(21, 'sodales at, velit. Pellentesque', 9304, 31008, 89),
(22, 'cursus et, magna. Praesent', 44575, 74584, 48),
(23, 'posuere at, velit. Cras', 93752, 64779, 100),
(24, 'Nunc quis arcu vel', 96310, 5893, 12),
(25, 'natoque penatibus et magnis', 47104, 15692, 63),
(26, 'Donec non justo. Proin', 44538, 32481, 29),
(27, 'Cras vulputate velit eu', 3308, 83214, 33),
(28, 'Vestibulum ante ipsum primis', 25283, 50410, 55),
(29, 'per inceptos hymenaeos. Mauris', 17038, 96758, 33),
(30, 'tincidunt adipiscing. Mauris molestie', 35071, 48575, 41),
(31, 'tempor diam dictum sapien.', 73568, 18521, 60),
(32, 'eget, volutpat ornare, facilisis', 74155, 61625, 30),
(33, 'Nam ligula elit, pretium', 5986, 60896, 12),
(34, 'natoque penatibus et magnis', 93752, 30027, 21),
(35, 'interdum ligula eu enim.', 70874, 50464, 43),
(36, 'suscipit, est ac facilisis', 24781, 91023, 1),
(37, 'venenatis lacus. Etiam bibendum', 60170, 30217, 64),
(38, 'metus. Aenean sed pede', 84963, 46844, 3),
(39, 'dui augue eu tellus.', 96054, 13075, 39),
(40, 'nulla. Integer urna. Vivamus', 92239, 87080, 66),
(41, 'accumsan convallis, ante lectus', 16608, 92104, 56),
(42, 'et arcu imperdiet ullamcorper.', 27252, 72148, 56),
(43, 'Integer urna. Vivamus molestie', 18064, 58829, 47),
(44, 'sem. Pellentesque ut ipsum', 50527, 20129, 99),
(45, 'Donec fringilla. Donec feugiat', 54692, 99801, 53),
(46, 'metus eu erat semper', 57264, 62223, 66),
(47, 'congue. In scelerisque scelerisque', 77291, 15659, 98),
(48, 'magna, malesuada vel, convallis', 13876, 76975, 96),
(49, 'diam dictum sapien. Aenean', 22590, 3066, 87),
(50, 'mollis. Phasellus libero mauris,', 80031, 54136, 66),
(51, 'urna. Nullam lobortis quam', 20941, 1931, 91),
(52, 'odio semper cursus. Integer', 45803, 82469, 49),
(53, 'lacus, varius et, euismod', 42032, 77589, 69),
(54, 'Praesent eu nulla at', 58661, 24249, 35),
(55, 'varius ultrices, mauris ipsum', 4599, 67058, 11),
(56, 'sed pede. Cum sociis', 53360, 34830, 18),
(57, 'auctor, velit eget laoreet', 80297, 28708, 88),
(58, 'nunc interdum feugiat. Sed', 47167, 58307, 63),
(59, 'congue. In scelerisque scelerisque', 32651, 6458, 93),
(60, 'accumsan neque et nunc.', 31759, 67455, 6),
(61, 'convallis in, cursus et,', 87491, 13139, 54),
(62, 'amet, consectetuer adipiscing elit.', 4243, 3790, 55),
(63, 'nec mauris blandit mattis.', 68195, 40102, 2),
(64, 'turpis. Nulla aliquet. Proin', 54736, 57466, 39),
(65, 'Aliquam adipiscing lobortis risus.', 8984, 58750, 39),
(66, 'in faucibus orci luctus', 3119, 78512, 6),
(67, 'elit, pharetra ut, pharetra', 4287, 19628, 78),
(68, 'Curabitur egestas nunc sed', 82549, 31042, 53),
(69, 'lacus vestibulum lorem, sit', 83915, 83248, 64),
(70, 'Donec consectetuer mauris id', 40479, 62326, 73),
(71, 'sociis natoque penatibus et', 83843, 21071, 71),
(72, 'Sed auctor odio a', 99017, 37255, 39),
(73, 'auctor vitae, aliquet nec,', 77540, 5892, 68),
(74, 'aliquam arcu. Aliquam ultrices', 87633, 79794, 70),
(75, 'et malesuada fames ac', 65524, 32814, 16),
(76, 'Mauris non dui nec', 15620, 72395, 96),
(77, 'semper auctor. Mauris vel', 67621, 35453, 49),
(78, 'in, tempus eu, ligula.', 99703, 50770, 45),
(79, 'vitae, aliquet nec, imperdiet', 86109, 32660, 10),
(80, 'eu turpis. Nulla aliquet.', 83773, 83986, 14),
(81, 'dis parturient montes, nascetur', 88676, 90689, 72),
(82, 'mus. Donec dignissim magna', 1180, 63552, 36),
(83, 'enim non nisi. Aenean', 55386, 71671, 51),
(84, 'id nunc interdum feugiat.', 67232, 36440, 85),
(85, 'semper. Nam tempor diam', 18085, 88762, 34),
(86, 'sit amet, consectetuer adipiscing', 27557, 19690, 70),
(87, 'eu lacus. Quisque imperdiet,', 35514, 50998, 87),
(88, 'semper tellus id nunc', 82934, 94184, 69),
(89, 'lacus pede sagittis augue,', 82953, 87883, 38),
(90, 'Aliquam adipiscing lobortis risus.', 53436, 9554, 64),
(91, 'elit. Aliquam auctor, velit', 38254, 68713, 84),
(92, 'ut, molestie in, tempus', 75344, 11082, 31),
(93, 'Nunc sollicitudin commodo ipsum.', 27469, 26427, 43),
(94, 'Aliquam erat volutpat. Nulla', 11630, 88139, 59),
(95, 'sem molestie sodales. Mauris', 2415, 72005, 66),
(96, 'turpis egestas. Fusce aliquet', 11215, 4508, 83),
(97, 'elementum, lorem ut aliquam', 99648, 76084, 38),
(98, 'malesuada ut, sem. Nulla', 70604, 27668, 97),
(99, 'dictum. Phasellus in felis.', 4979, 3325, 63),
(100, 'ut cursus luctus, ipsum', 1631, 77466, 80);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Five`
--
ALTER TABLE `Depth_Five`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_four` (`depth_four_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Five`
--
ALTER TABLE `Depth_Five`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Five`
--
ALTER TABLE `Depth_Five`
  ADD CONSTRAINT `fk_depth_four` FOREIGN KEY (`depth_four_id`) REFERENCES `Depth_Four` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
