-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:58:42
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
-- Struktur-dump for tabellen `Depth_Seven`
--

CREATE TABLE `Depth_Seven` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_six_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Seven`
--

INSERT INTO `Depth_Seven` (`id`, `string_value`, `int_value`, `double_value`, `depth_six_id`) VALUES
(1, 'viverra. Maecenas iaculis aliquet', 87430, 45287, 44),
(2, 'In nec orci. Donec', 31983, 93138, 61),
(3, 'nisl. Nulla eu neque', 59884, 25028, 75),
(4, 'scelerisque neque. Nullam nisl.', 45371, 4888, 72),
(5, 'fringilla, porttitor vulputate, posuere', 43225, 73834, 50),
(6, 'a neque. Nullam ut', 71433, 4633, 43),
(7, 'Fusce dolor quam, elementum', 59540, 39832, 49),
(8, 'pharetra. Quisque ac libero', 29654, 63628, 79),
(9, 'euismod enim. Etiam gravida', 51330, 44592, 10),
(10, 'elit, pretium et, rutrum', 81905, 61490, 23),
(11, 'Phasellus at augue id', 24674, 40778, 60),
(12, 'tellus. Suspendisse sed dolor.', 57609, 63877, 33),
(13, 'ultrices, mauris ipsum porta', 65981, 9511, 58),
(14, 'lobortis risus. In mi', 68954, 64991, 31),
(15, 'fames ac turpis egestas.', 88851, 32784, 59),
(16, 'dis parturient montes, nascetur', 30078, 14521, 63),
(17, 'ligula elit, pretium et,', 8706, 82035, 14),
(18, 'Donec sollicitudin adipiscing ligula.', 45412, 40167, 65),
(19, 'Integer eu lacus. Quisque', 97015, 58028, 22),
(20, 'fames ac turpis egestas.', 78552, 66179, 34),
(21, 'diam eu dolor egestas', 56665, 7166, 84),
(22, 'Proin non massa non', 64535, 69865, 91),
(23, 'semper cursus. Integer mollis.', 80527, 97784, 57),
(24, 'Aenean massa. Integer vitae', 15499, 92958, 86),
(25, 'eu neque pellentesque massa', 33085, 8587, 81),
(26, 'faucibus orci luctus et', 21217, 79461, 75),
(27, 'pede, nonummy ut, molestie', 37535, 58905, 52),
(28, 'vehicula risus. Nulla eget', 7263, 14733, 89),
(29, 'luctus vulputate, nisi sem', 90412, 36485, 11),
(30, 'purus. Maecenas libero est,', 49170, 57551, 45),
(31, 'Proin velit. Sed malesuada', 91875, 87126, 77),
(32, 'gravida nunc sed pede.', 41385, 39737, 82),
(33, 'Proin eget odio. Aliquam', 15022, 81453, 18),
(34, 'In faucibus. Morbi vehicula.', 2575, 92412, 51),
(35, 'eget tincidunt dui augue', 85831, 33095, 61),
(36, 'felis. Nulla tempor augue', 68900, 24365, 17),
(37, 'Cras lorem lorem, luctus', 75815, 3826, 37),
(38, 'augue porttitor interdum. Sed', 79821, 68419, 84),
(39, 'tempus eu, ligula. Aenean', 29625, 68136, 45),
(40, 'in, tempus eu, ligula.', 73364, 29069, 92),
(41, 'auctor non, feugiat nec,', 34518, 60480, 60),
(42, 'faucibus orci luctus et', 70195, 63449, 35),
(43, 'Aliquam erat volutpat. Nulla', 14392, 65598, 7),
(44, 'euismod et, commodo at,', 9906, 56075, 73),
(45, 'mauris. Morbi non sapien', 26145, 81284, 12),
(46, 'at, velit. Cras lorem', 21722, 98861, 2),
(47, 'est. Mauris eu turpis.', 31604, 15889, 3),
(48, 'condimentum. Donec at arcu.', 25163, 89901, 2),
(49, 'vel, vulputate eu, odio.', 70478, 78905, 46),
(50, 'Cum sociis natoque penatibus', 31975, 83766, 5),
(51, 'mauris sagittis placerat. Cras', 36979, 75714, 15),
(52, 'felis. Nulla tempor augue', 13712, 98744, 94),
(53, 'enim, sit amet ornare', 97187, 91580, 88),
(54, 'leo. Vivamus nibh dolor,', 60236, 10373, 80),
(55, 'dignissim pharetra. Nam ac', 16089, 78359, 19),
(56, 'tristique senectus et netus', 71557, 11833, 83),
(57, 'primis in faucibus orci', 16048, 38151, 41),
(58, 'Quisque ac libero nec', 72043, 54162, 47),
(59, 'Sed malesuada augue ut', 1499, 73190, 37),
(60, 'faucibus ut, nulla. Cras', 78435, 4585, 56),
(61, 'Ut tincidunt vehicula risus.', 60094, 80269, 1),
(62, 'mus. Donec dignissim magna', 17500, 21653, 92),
(63, 'at fringilla purus mauris', 28120, 73704, 6),
(64, 'et pede. Nunc sed', 18937, 67026, 78),
(65, 'dictum magna. Ut tincidunt', 82990, 81593, 76),
(66, 'metus eu erat semper', 43558, 3205, 92),
(67, 'velit. Quisque varius. Nam', 26660, 58805, 29),
(68, 'dui. Cum sociis natoque', 6825, 50044, 47),
(69, 'adipiscing. Mauris molestie pharetra', 44260, 97506, 39),
(70, 'ullamcorper eu, euismod ac,', 18784, 97961, 40),
(71, 'Duis ac arcu. Nunc', 65097, 59123, 70),
(72, 'dolor, tempus non, lacinia', 55432, 42601, 52),
(73, 'arcu. Vestibulum ante ipsum', 82026, 62133, 63),
(74, 'dictum eleifend, nunc risus', 42823, 82864, 77),
(75, 'lobortis mauris. Suspendisse aliquet', 68168, 98546, 66),
(76, 'ipsum porta elit, a', 91093, 35523, 53),
(77, 'iaculis odio. Nam interdum', 32974, 7025, 50),
(78, 'dolor dolor, tempus non,', 28565, 82067, 23),
(79, 'amet risus. Donec egestas.', 59134, 25621, 30),
(80, 'sit amet, faucibus ut,', 58031, 30119, 21),
(81, 'mi. Duis risus odio,', 46103, 38569, 1),
(82, 'Cras vulputate velit eu', 80727, 69562, 17),
(83, 'ut odio vel est', 88810, 84535, 28),
(84, 'et malesuada fames ac', 21699, 94771, 30),
(85, 'volutpat ornare, facilisis eget,', 62974, 66612, 74),
(86, 'ornare. Fusce mollis. Duis', 18031, 90277, 46),
(87, 'Maecenas mi felis, adipiscing', 3833, 85003, 32),
(88, 'in, dolor. Fusce feugiat.', 62430, 54349, 50),
(89, 'dolor. Quisque tincidunt pede', 56542, 6698, 79),
(90, 'sed consequat auctor, nunc', 89087, 39948, 48),
(91, 'Nam interdum enim non', 99812, 41944, 71),
(92, 'amet, faucibus ut, nulla.', 93722, 70093, 23),
(93, 'sed dui. Fusce aliquam,', 75955, 53805, 47),
(94, 'nisi dictum augue malesuada', 56400, 83458, 75),
(95, 'ipsum cursus vestibulum. Mauris', 87383, 79781, 76),
(96, 'elementum purus, accumsan interdum', 30807, 80305, 50),
(97, 'Nunc mauris. Morbi non', 99855, 14872, 22),
(98, 'felis. Donec tempor, est', 35966, 74385, 48),
(99, 'ipsum. Phasellus vitae mauris', 42114, 41948, 19),
(100, 'Ut sagittis lobortis mauris.', 31796, 89690, 60);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Seven`
--
ALTER TABLE `Depth_Seven`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_six` (`depth_six_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Seven`
--
ALTER TABLE `Depth_Seven`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Seven`
--
ALTER TABLE `Depth_Seven`
  ADD CONSTRAINT `fk_depth_six` FOREIGN KEY (`depth_six_id`) REFERENCES `Depth_Six` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
