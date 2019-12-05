-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Vært: mysql50.unoeuro.com
-- Genereringstid: 05. 12 2019 kl. 11:56:57
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
-- Struktur-dump for tabellen `Depth_Two`
--

CREATE TABLE `Depth_Two` (
  `id` int(6) UNSIGNED NOT NULL,
  `string_value` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `int_value` int(50) NOT NULL,
  `double_value` double NOT NULL,
  `depth_one_id` int(6) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Data dump for tabellen `Depth_Two`
--

INSERT INTO `Depth_Two` (`id`, `string_value`, `int_value`, `double_value`, `depth_one_id`) VALUES
(1, 'semper, dui lectus rutrum', 54092, 95218, 39),
(2, 'ornare, lectus ante dictum', 73655, 31347, 72),
(3, 'quis diam. Pellentesque habitant', 35252, 95018, 39),
(4, 'accumsan sed, facilisis vitae,', 26298, 25196, 39),
(5, 'facilisis facilisis, magna tellus', 22844, 42146, 48),
(6, 'dictum. Proin eget odio.', 90845, 6865, 80),
(7, 'risus. Donec nibh enim,', 29481, 1047, 96),
(8, 'ipsum. Phasellus vitae mauris', 11493, 1112, 21),
(9, 'massa. Integer vitae nibh.', 76122, 79251, 67),
(10, 'cursus. Integer mollis. Integer', 43156, 66777, 26),
(11, 'Fusce fermentum fermentum arcu.', 25900, 45675, 42),
(12, 'tellus. Nunc lectus pede,', 2268, 8704, 81),
(13, 'vel turpis. Aliquam adipiscing', 56238, 4485, 82),
(14, 'non arcu. Vivamus sit', 63153, 58839, 60),
(15, 'dictum eu, placerat eget,', 31872, 4587, 26),
(16, 'in, cursus et, eros.', 45245, 29543, 61),
(17, 'interdum. Curabitur dictum. Phasellus', 37686, 92100, 31),
(18, 'eget laoreet posuere, enim', 59243, 12497, 42),
(19, 'eget massa. Suspendisse eleifend.', 79197, 32617, 75),
(20, 'eget lacus. Mauris non', 94854, 87353, 40),
(21, 'elit elit fermentum risus,', 24552, 34457, 94),
(22, 'vitae velit egestas lacinia.', 43358, 7887, 42),
(23, 'gravida. Aliquam tincidunt, nunc', 23633, 67297, 67),
(24, 'sed, est. Nunc laoreet', 92070, 66605, 57),
(25, 'neque. Nullam ut nisi', 81460, 65545, 82),
(26, 'accumsan neque et nunc.', 25439, 73014, 77),
(27, 'Nulla aliquet. Proin velit.', 32643, 65435, 63),
(28, 'nunc interdum feugiat. Sed', 52115, 87460, 92),
(29, 'ligula consectetuer rhoncus. Nullam', 4623, 16572, 75),
(30, 'ac facilisis facilisis, magna', 79882, 87991, 90),
(31, 'quis accumsan convallis, ante', 62393, 50931, 75),
(32, 'orci lobortis augue scelerisque', 19668, 7531, 84),
(33, 'arcu. Vestibulum ante ipsum', 51364, 87085, 16),
(34, 'ultricies ligula. Nullam enim.', 66679, 63460, 47),
(35, 'nisl elementum purus, accumsan', 81275, 52980, 67),
(36, 'risus quis diam luctus', 86467, 50178, 97),
(37, 'condimentum. Donec at arcu.', 87948, 63980, 33),
(38, 'purus, accumsan interdum libero', 72970, 48987, 3),
(39, 'libero. Proin sed turpis', 62438, 36362, 98),
(40, 'a neque. Nullam ut', 37972, 83589, 54),
(41, 'molestie orci tincidunt adipiscing.', 26391, 54787, 9),
(42, 'a, enim. Suspendisse aliquet,', 37845, 46541, 61),
(43, 'mollis. Duis sit amet', 38226, 99559, 13),
(44, 'massa. Vestibulum accumsan neque', 73730, 44764, 15),
(45, 'non nisi. Aenean eget', 86077, 86410, 94),
(46, 'neque. In ornare sagittis', 32954, 4819, 56),
(47, 'Aenean euismod mauris eu', 29047, 64090, 18),
(48, 'Vestibulum ante ipsum primis', 94489, 24774, 5),
(49, 'egestas ligula. Nullam feugiat', 57635, 9210, 18),
(50, 'blandit congue. In scelerisque', 70956, 52451, 56),
(51, 'Sed auctor odio a', 17525, 37469, 89),
(52, 'Curabitur egestas nunc sed', 19477, 30458, 82),
(53, 'nec urna suscipit nonummy.', 32546, 16143, 19),
(54, 'orci lacus vestibulum lorem,', 31740, 92808, 40),
(55, 'elementum sem, vitae aliquam', 59812, 40365, 36),
(56, 'velit in aliquet lobortis,', 32275, 83634, 95),
(57, 'et, rutrum eu, ultrices', 12303, 7934, 93),
(58, 'cursus in, hendrerit consectetuer,', 82423, 26731, 44),
(59, 'pede ac urna. Ut', 89089, 31696, 46),
(60, 'dui lectus rutrum urna,', 35299, 30766, 22),
(61, 'magna. Cras convallis convallis', 82385, 44620, 96),
(62, 'Aliquam fringilla cursus purus.', 90976, 75484, 50),
(63, 'nec ligula consectetuer rhoncus.', 79026, 17726, 57),
(64, 'Donec fringilla. Donec feugiat', 22212, 81406, 85),
(65, 'elementum purus, accumsan interdum', 80783, 39444, 71),
(66, 'amet massa. Quisque porttitor', 20062, 96741, 9),
(67, 'elit sed consequat auctor,', 1801, 97510, 42),
(68, 'blandit mattis. Cras eget', 7811, 42541, 69),
(69, 'nec urna et arcu', 76970, 63260, 72),
(70, 'Nam interdum enim non', 63658, 74480, 5),
(71, 'magna. Praesent interdum ligula', 66896, 92389, 52),
(72, 'non justo. Proin non', 84790, 42669, 10),
(73, 'eleifend, nunc risus varius', 4276, 80067, 87),
(74, 'montes, nascetur ridiculus mus.', 35682, 86380, 11),
(75, 'Fusce diam nunc, ullamcorper', 22226, 89555, 72),
(76, 'vestibulum, neque sed dictum', 9607, 57964, 90),
(77, 'in, cursus et, eros.', 50562, 30598, 50),
(78, 'non lorem vitae odio', 44230, 74299, 69),
(79, 'venenatis vel, faucibus id,', 33980, 20916, 28),
(80, 'sed, est. Nunc laoreet', 55286, 90023, 64),
(81, 'Curabitur massa. Vestibulum accumsan', 57662, 34507, 89),
(82, 'Mauris magna. Duis dignissim', 41346, 57924, 87),
(83, 'nascetur ridiculus mus. Proin', 58067, 69771, 44),
(84, 'diam eu dolor egestas', 50328, 44652, 53),
(85, 'tellus lorem eu metus.', 89550, 92721, 77),
(86, 'ante. Vivamus non lorem', 25393, 70375, 80),
(87, 'parturient montes, nascetur ridiculus', 3191, 63777, 12),
(88, 'Quisque nonummy ipsum non', 19869, 33436, 64),
(89, 'Mauris non dui nec', 91943, 68835, 100),
(90, 'in consequat enim diam', 96768, 29765, 49),
(91, 'parturient montes, nascetur ridiculus', 45836, 43277, 66),
(92, 'facilisis. Suspendisse commodo tincidunt', 31772, 73029, 58),
(93, 'aptent taciti sociosqu ad', 58559, 96136, 86),
(94, 'Quisque fringilla euismod enim.', 69089, 63950, 41),
(95, 'amet, dapibus id, blandit', 99476, 80289, 70),
(96, 'quis lectus. Nullam suscipit,', 72400, 76800, 78),
(97, 'sit amet orci. Ut', 79077, 63457, 17),
(98, 'suscipit, est ac facilisis', 52360, 49487, 33),
(99, 'enim diam vel arcu.', 9748, 77719, 88),
(100, 'ac orci. Ut semper', 61747, 43604, 60);

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `Depth_Two`
--
ALTER TABLE `Depth_Two`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_depth_one` (`depth_one_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `Depth_Two`
--
ALTER TABLE `Depth_Two`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `Depth_Two`
--
ALTER TABLE `Depth_Two`
  ADD CONSTRAINT `fk_depth_one` FOREIGN KEY (`depth_one_id`) REFERENCES `Depth_One` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
