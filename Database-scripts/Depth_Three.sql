-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:57:08
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
-- Struktur-dump for tabellen `Depth_Three`
--

CREATE TABLE `Depth_Three` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_two_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Three`
--

INSERT INTO `Depth_Three` (`id`, `string_value`, `int_value`, `double_value`, `depth_two_id`) VALUES
(1, 'dui, semper et, lacinia', 56738, 8481, 25),
(2, 'sit amet ornare lectus', 40570, 41800, 83),
(3, 'natoque penatibus et magnis', 88308, 45024, 41),
(4, 'fermentum fermentum arcu. Vestibulum', 29193, 9796, 19),
(5, 'morbi tristique senectus et', 38099, 28691, 98),
(6, 'amet risus. Donec egestas.', 29206, 90635, 41),
(7, 'Nulla semper tellus id', 68845, 78876, 52),
(8, 'cubilia Curae; Phasellus ornare.', 78617, 28354, 17),
(9, 'euismod est arcu ac', 61726, 53101, 19),
(10, 'tellus. Aenean egestas hendrerit', 97515, 63972, 49),
(11, 'egestas. Fusce aliquet magna', 6600, 48745, 32),
(12, 'ullamcorper, nisl arcu iaculis', 51759, 99772, 100),
(13, 'pretium neque. Morbi quis', 3213, 5913, 30),
(14, 'rhoncus. Donec est. Nunc', 18430, 6296, 98),
(15, 'Nulla facilisi. Sed neque.', 50518, 19435, 89),
(16, 'sit amet, risus. Donec', 90531, 53768, 50),
(17, 'Nunc ut erat. Sed', 33770, 65251, 71),
(18, 'ac, eleifend vitae, erat.', 26665, 20019, 9),
(19, 'nec, leo. Morbi neque', 29620, 19193, 55),
(20, 'Ut nec urna et', 80069, 32800, 68),
(21, 'Duis gravida. Praesent eu', 72779, 17891, 33),
(22, 'sed leo. Cras vehicula', 26497, 19605, 26),
(23, 'sed libero. Proin sed', 49212, 58535, 30),
(24, 'adipiscing elit. Aliquam auctor,', 25876, 96762, 30),
(25, 'luctus. Curabitur egestas nunc', 53766, 71900, 98),
(26, 'aliquam eros turpis non', 50769, 5239, 49),
(27, 'parturient montes, nascetur ridiculus', 73774, 51974, 36),
(28, 'amet nulla. Donec non', 98708, 10543, 38),
(29, 'id, mollis nec, cursus', 96156, 67853, 24),
(30, 'quis arcu vel quam', 54623, 4989, 59),
(31, 'lobortis mauris. Suspendisse aliquet', 96389, 2481, 85),
(32, 'lectus pede, ultrices a,', 63216, 67576, 70),
(33, 'magna. Phasellus dolor elit,', 75965, 7265, 64),
(34, 'diam lorem, auctor quis,', 31518, 77534, 37),
(35, 'tristique pellentesque, tellus sem', 91482, 48668, 100),
(36, 'euismod et, commodo at,', 55208, 74710, 34),
(37, 'adipiscing ligula. Aenean gravida', 40424, 2879, 23),
(38, 'lacus. Etiam bibendum fermentum', 58037, 21284, 3),
(39, 'in aliquet lobortis, nisi', 99357, 29340, 62),
(40, 'lobortis augue scelerisque mollis.', 64128, 6274, 81),
(41, 'Nulla facilisis. Suspendisse commodo', 38278, 63665, 52),
(42, 'ut dolor dapibus gravida.', 78628, 82408, 18),
(43, 'egestas. Fusce aliquet magna', 23017, 13639, 100),
(44, 'adipiscing elit. Curabitur sed', 6906, 32622, 46),
(45, 'porttitor tellus non magna.', 12449, 25763, 75),
(46, 'consectetuer mauris id sapien.', 43632, 78831, 86),
(47, 'massa lobortis ultrices. Vivamus', 13145, 27455, 19),
(48, 'eget, venenatis a, magna.', 7700, 84676, 19),
(49, 'eleifend egestas. Sed pharetra,', 48287, 44415, 27),
(50, 'cursus in, hendrerit consectetuer,', 2064, 2716, 72),
(51, 'ligula. Nullam enim. Sed', 97237, 23706, 52),
(52, 'sed dolor. Fusce mi', 40848, 70392, 96),
(53, 'velit. Quisque varius. Nam', 48107, 13196, 56),
(54, 'enim. Sed nulla ante,', 20415, 66687, 22),
(55, 'Cras sed leo. Cras', 29512, 29363, 72),
(56, 'vitae nibh. Donec est', 83602, 91662, 87),
(57, 'eu arcu. Morbi sit', 21018, 6910, 85),
(58, 'nunc, ullamcorper eu, euismod', 48541, 90020, 22),
(59, 'tincidunt, neque vitae semper', 41992, 5731, 77),
(60, 'ut, pharetra sed, hendrerit', 88541, 5743, 6),
(61, 'enim. Etiam gravida molestie', 58298, 45407, 21),
(62, 'egestas nunc sed libero.', 65930, 32349, 82),
(63, 'dolor quam, elementum at,', 98540, 65440, 85),
(64, 'Donec tempor, est ac', 23539, 7405, 37),
(65, 'risus, at fringilla purus', 11397, 36817, 10),
(66, 'risus. Nunc ac sem', 29234, 43975, 4),
(67, 'nibh enim, gravida sit', 82922, 59113, 52),
(68, 'et magnis dis parturient', 21267, 45010, 72),
(69, 'bibendum fermentum metus. Aenean', 88581, 80114, 58),
(70, 'et magnis dis parturient', 26683, 50246, 50),
(71, 'sem ut cursus luctus,', 19968, 58838, 72),
(72, 'imperdiet, erat nonummy ultricies', 19784, 17542, 58),
(73, 'vel, convallis in, cursus', 39940, 40980, 20),
(74, 'augue ac ipsum. Phasellus', 99433, 84793, 46),
(75, 'justo. Praesent luctus. Curabitur', 12942, 38650, 38),
(76, 'velit eget laoreet posuere,', 70081, 62387, 81),
(77, 'justo. Proin non massa', 14753, 63474, 52),
(78, 'ac turpis egestas. Fusce', 93838, 8748, 80),
(79, 'eget, volutpat ornare, facilisis', 52453, 1608, 67),
(80, 'nulla at sem molestie', 33873, 57279, 97),
(81, 'tristique pharetra. Quisque ac', 35914, 41728, 31),
(82, 'lorem, auctor quis, tristique', 48218, 99469, 73),
(83, 'lacus vestibulum lorem, sit', 7768, 21822, 51),
(84, 'Donec fringilla. Donec feugiat', 53677, 53150, 31),
(85, 'pede sagittis augue, eu', 19649, 92917, 51),
(86, 'in molestie tortor nibh', 48972, 81553, 20),
(87, 'senectus et netus et', 36855, 30794, 33),
(88, 'morbi tristique senectus et', 12020, 19728, 89),
(89, 'urna. Nunc quis arcu', 36601, 26139, 45),
(90, 'sollicitudin commodo ipsum. Suspendisse', 51191, 92515, 83),
(91, 'nonummy ultricies ornare, elit', 8642, 75244, 18),
(92, 'Vivamus non lorem vitae', 3904, 99965, 44),
(93, 'in molestie tortor nibh', 62201, 5939, 47),
(94, 'Praesent eu nulla at', 21287, 9778, 16),
(95, 'erat. Etiam vestibulum massa', 75230, 14525, 8),
(96, 'vel turpis. Aliquam adipiscing', 22557, 29367, 60),
(97, 'turpis egestas. Fusce aliquet', 79627, 65282, 16),
(98, 'Suspendisse aliquet molestie tellus.', 51569, 63231, 10),
(99, 'Donec dignissim magna a', 11049, 47752, 82),
(100, 'Vivamus nisi. Mauris nulla.', 31999, 40388, 94);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Three`
--
ALTER TABLE `Depth_Three`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_two` (`depth_two_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Three`
--
ALTER TABLE `Depth_Three`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Three`
--
ALTER TABLE `Depth_Three`
  ADD CONSTRAINT `fk_depth_two` FOREIGN KEY (`depth_two_id`) REFERENCES `Depth_Two` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
